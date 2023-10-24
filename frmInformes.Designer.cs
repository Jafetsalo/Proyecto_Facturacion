namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmInformes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtInformeRich = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.cmbInforme = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.LblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.LblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.LblInforme = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxtInformeRich
            // 
            this.TxtInformeRich.Location = new System.Drawing.Point(64, 277);
            this.TxtInformeRich.Name = "TxtRichDatosAdicionales";
            this.TxtInformeRich.Size = new System.Drawing.Size(548, 213);
            this.TxtInformeRich.TabIndex = 42;
            this.TxtInformeRich.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(629, 452);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(106, 38);
            this.BtnSalir.TabIndex = 41;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.Depth = 0;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(629, 231);
            this.BtnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenerarInforme.Name = "BtnGenerarInforme";
            this.BtnGenerarInforme.Primary = true;
            this.BtnGenerarInforme.Size = new System.Drawing.Size(106, 40);
            this.BtnGenerarInforme.TabIndex = 40;
            this.BtnGenerarInforme.Text = "GENERAR INFORME";
            this.BtnGenerarInforme.UseVisualStyleBackColor = true;
            this.BtnGenerarInforme.Click += new System.EventHandler(this.BtnGenerarInforme_Click);
            // 
            // dateFechaRegistro
            // 
            this.dateFechaRegistro.Location = new System.Drawing.Point(560, 178);
            this.dateFechaRegistro.Name = "dateFechaRetiro";
            this.dateFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dateFechaRegistro.TabIndex = 39;
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Location = new System.Drawing.Point(560, 132);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(200, 21);
            this.cmbEstadoFactura.TabIndex = 38;
            // 
            // cmbInforme
            // 
            this.cmbInforme.FormattingEnabled = true;
            this.cmbInforme.Location = new System.Drawing.Point(189, 130);
            this.cmbInforme.Name = "cmbInforme";
            this.cmbInforme.Size = new System.Drawing.Size(225, 21);
            this.cmbInforme.TabIndex = 36;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(234, -40);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(212, 19);
            this.LblTitulo.TabIndex = 34;
            this.LblTitulo.Text = "ADMINISTRACION FACTURAS";
            // 
            // LblOrdenarPor
            // 
            this.LblOrdenarPor.AutoSize = true;
            this.LblOrdenarPor.Depth = 0;
            this.LblOrdenarPor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblOrdenarPor.Location = new System.Drawing.Point(444, 132);
            this.LblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOrdenarPor.Name = "LblOrdenarPor";
            this.LblOrdenarPor.Size = new System.Drawing.Size(88, 19);
            this.LblOrdenarPor.TabIndex = 33;
            this.LblOrdenarPor.Text = "Ordenar Por";
            // 
            // LblFechaFinal
            // 
            this.LblFechaFinal.AutoSize = true;
            this.LblFechaFinal.Depth = 0;
            this.LblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaFinal.Location = new System.Drawing.Point(445, 179);
            this.LblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaFinal.Name = "LblFechaFinal";
            this.LblFechaFinal.Size = new System.Drawing.Size(85, 19);
            this.LblFechaFinal.TabIndex = 32;
            this.LblFechaFinal.Text = "Fecha Final";
            // 
            // LblInforme
            // 
            this.LblInforme.AutoSize = true;
            this.LblInforme.Depth = 0;
            this.LblInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInforme.Location = new System.Drawing.Point(9, 132);
            this.LblInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInforme.Name = "LblInforme";
            this.LblInforme.Size = new System.Drawing.Size(166, 19);
            this.LblInforme.TabIndex = 27;
            this.LblInforme.Text = "SELECCIONE INFORME";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(167, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(324, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(189, 179);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(199, 20);
            this.dateFechaInicio.TabIndex = 45;
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Depth = 0;
            this.LblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaInicio.Location = new System.Drawing.Point(74, 180);
            this.LblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.LblFechaInicio.TabIndex = 44;
            this.LblFechaInicio.Text = "Fecha Inicio";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(194, 231);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "En Pantalla";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(285, 232);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PDF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(337, 231);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 48;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Excel";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 569);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtInformeRich);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGenerarInforme);
            this.Controls.Add(this.dateFechaRegistro);
            this.Controls.Add(this.cmbEstadoFactura);
            this.Controls.Add(this.cmbInforme);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblOrdenarPor);
            this.Controls.Add(this.LblFechaFinal);
            this.Controls.Add(this.LblInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtInformeRich;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGenerarInforme;
        private System.Windows.Forms.DateTimePicker dateFechaRegistro;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.ComboBox cmbInforme;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialLabel LblOrdenarPor;
        private MaterialSkin.Controls.MaterialLabel LblFechaFinal;
        private MaterialSkin.Controls.MaterialLabel LblInforme;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private MaterialSkin.Controls.MaterialLabel LblFechaInicio;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}