using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using tessnet2;

namespace AppConsultaRucSunat
{
    public class ConsultaRucSunat
    {
        string captcha = "";
        Encoding objEncoding = Encoding.GetEncoding("UTF-8");
        private static HttpClient httpClient = new HttpClient(new HttpClientHandler { UseProxy = true, });
        string rutaTessData = string.Empty;
        public ConsultaRucSunat()
        {
            // Inicializa por unica vez la direcciÓn base
            if(httpClient.BaseAddress == null)
                httpClient.BaseAddress = new Uri("http://e-consultaruc.sunat.gob.pe/");

            // IndicaNDO la ruta de la librería. 
            rutaTessData = Application.StartupPath + @"\tessdata\";
        }

        public async Task<Contribuyente> ConsultaRuc(string ruc)
        {
            Contribuyente contribuyente = new Contribuyente();
            try
            {
                ServicePointManager.DefaultConnectionLimit = 2;

                // Descarga la imagen captcha
                HttpResponseMessage responseMessage = await httpClient.GetAsync($"cl-ti-itmrconsruc/captcha?accion=image");
                if (responseMessage.IsSuccessStatusCode)
                {
                    Stream responseStream = await responseMessage.Content.ReadAsStreamAsync(); ;
                    var image = new Bitmap(responseStream);
                    var ocr = new Tesseract();

                    // Indicamos la ruta de la libreria
                    ocr.Init(rutaTessData, "eng", false);

                    // Convertir la imagen a texto plano
                    var result = ocr.DoOCR(image, Rectangle.Empty);
                    foreach (Word word in result)
                    {
                        captcha += word.Text;
                    }

                }
                else
                    return null;

                // Consulta el RUC enviando el codigo captcha
                var ConsultaRuc = await httpClient.GetAsync($"cl-ti-itmrconsruc/jcrS03Alias?accion=consPorRuc&razSoc=&nroRuc={ruc}&nrodoc=&contexto=ti-it&tQuery=on&search1={ruc}&tipdoc=1&search2=&coddpto=&codprov=&coddist=&search3=&codigo={captcha.Trim().ToUpper()}&tipodocumento=1");

                // Si la consulta es exitosa
                if (ConsultaRuc.IsSuccessStatusCode)
                {
                    string msg = string.Empty;

                    // Libreria que permite trabajar con etiquetas HTML
                    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();

                    // Carga el contenido html de la consulta
                    document.LoadHtml(await ConsultaRuc.Content.ReadAsStringAsync());
                    var NodeTable = document.DocumentNode
                                            .SelectNodes("//table")
                                            .FirstOrDefault();
                    if (NodeTable != null)
                    {
                        var listNodeTr = NodeTable.Elements("tr").ToArray();
                        if (listNodeTr != null)
                        {
                            // Extrae los valores de las celdas de la tabla. 
                            var nodeRazonSocial = listNodeTr[1].Elements("td").ToArray();
                            if (nodeRazonSocial != null)
                            {
                                string ConsultaCliente = LimpiarEspacios(nodeRazonSocial[1].InnerHtml.Trim());
                                contribuyente.RUC = ConsultaCliente.Substring(0, 11).Trim();
                                contribuyente.RazonSocial = ConsultaCliente.Substring(13, ConsultaCliente.Length - 13).Trim();
                            }
                            var nodeDireccion = listNodeTr[7].Elements("td").ToArray();
                            if (ruc.StartsWith("10"))
                            {
                                nodeDireccion = listNodeTr[8].Elements("td").ToArray();
                            }
                            if (nodeDireccion != null)
                            {
                                string ConsultaDireccion = LimpiarEspacios(nodeDireccion[1].InnerHtml.Trim());
                                contribuyente.Direccion = ConsultaDireccion.Trim();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {              
            }
            return await Task.Run(() => contribuyente);
        }

        private string LimpiarEspacios(string cadena)
        {
            while (cadena.Contains("  "))
            {
                cadena = cadena.Replace("  ", " ");
            }
            return cadena;
        }
    }
}
