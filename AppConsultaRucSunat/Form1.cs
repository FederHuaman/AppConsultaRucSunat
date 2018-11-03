using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace AppConsultaRucSunat
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbDatosRuc.Text = "Resultado de la Consulta";
        }

        private async void btnConsultaSunat_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaRucSunat consultaRucSunat = new ConsultaRucSunat();
                btnConsultaSunat.Text = "Consultando...";
                Contribuyente contribuyente = await consultaRucSunat.ConsultaRuc(txtRuc.Text);
                txtRazonSocial.Text = contribuyente.RazonSocial;
                txtDirección.Text = contribuyente.Direccion;
                btnConsultaSunat.Text = "Consultar a SUNAT";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en btnConsultaSunat_Click : " + ex.Message);
            }
        }
    }
}
