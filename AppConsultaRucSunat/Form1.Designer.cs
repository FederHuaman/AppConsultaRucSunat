namespace AppConsultaRucSunat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRuc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gbDatosRuc = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtDirección = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRazonSocial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnConsultaSunat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosRuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosRuc.Panel)).BeginInit();
            this.gbDatosRuc.Panel.SuspendLayout();
            this.gbDatosRuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(76, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "RUC :";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(120, 26);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(169, 23);
            this.txtRuc.TabIndex = 1;
            // 
            // gbDatosRuc
            // 
            this.gbDatosRuc.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            this.gbDatosRuc.Location = new System.Drawing.Point(12, 55);
            this.gbDatosRuc.Name = "gbDatosRuc";
            // 
            // gbDatosRuc.Panel
            // 
            this.gbDatosRuc.Panel.Controls.Add(this.txtDirección);
            this.gbDatosRuc.Panel.Controls.Add(this.txtRazonSocial);
            this.gbDatosRuc.Panel.Controls.Add(this.kryptonLabel3);
            this.gbDatosRuc.Panel.Controls.Add(this.kryptonLabel2);
            this.gbDatosRuc.Size = new System.Drawing.Size(550, 107);
            this.gbDatosRuc.TabIndex = 2;
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(107, 44);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.ReadOnly = true;
            this.txtDirección.Size = new System.Drawing.Size(436, 23);
            this.txtDirección.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(107, 15);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(436, 23);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(33, 44);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Dirección :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Razón Social :";
            // 
            // btnConsultaSunat
            // 
            this.btnConsultaSunat.Location = new System.Drawing.Point(295, 24);
            this.btnConsultaSunat.Name = "btnConsultaSunat";
            this.btnConsultaSunat.Size = new System.Drawing.Size(132, 25);
            this.btnConsultaSunat.TabIndex = 3;
            this.btnConsultaSunat.Values.Text = "Consultar a SUNAT";
            this.btnConsultaSunat.Click += new System.EventHandler(this.btnConsultaSunat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 170);
            this.Controls.Add(this.btnConsultaSunat);
            this.Controls.Add(this.gbDatosRuc);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.kryptonLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONSULTA DE RUC A SUNAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosRuc.Panel)).EndInit();
            this.gbDatosRuc.Panel.ResumeLayout(false);
            this.gbDatosRuc.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosRuc)).EndInit();
            this.gbDatosRuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRuc;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbDatosRuc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDirección;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRazonSocial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConsultaSunat;
    }
}

