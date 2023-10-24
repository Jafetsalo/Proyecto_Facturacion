namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmFacturas
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
            this.LblNumeroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.LblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.LblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.LblDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.LblIva = new MaterialSkin.Controls.MaterialLabel();
            this.LblTotalFactura = new MaterialSkin.Controls.MaterialLabel();
            this.LblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.LblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.dateFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtFacturaRich = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LblNumeroFactura
            // 
            this.LblNumeroFactura.AutoSize = true;
            this.LblNumeroFactura.Depth = 0;
            this.LblNumeroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumeroFactura.Location = new System.Drawing.Point(135, 141);
            this.LblNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumeroFactura.Name = "LblNumeroFactura";
            this.LblNumeroFactura.Size = new System.Drawing.Size(117, 19);
            this.LblNumeroFactura.TabIndex = 0;
            this.LblNumeroFactura.Text = "Numero Factura";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Depth = 0;
            this.LblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCliente.Location = new System.Drawing.Point(135, 178);
            this.LblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(56, 19);
            this.LblCliente.TabIndex = 1;
            this.LblCliente.Text = "Cliente";
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Depth = 0;
            this.LblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEmpleado.Location = new System.Drawing.Point(135, 222);
            this.LblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.LblEmpleado.TabIndex = 2;
            this.LblEmpleado.Text = "Empleado";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Depth = 0;
            this.LblDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescuento.Location = new System.Drawing.Point(135, 265);
            this.LblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(81, 19);
            this.LblDescuento.TabIndex = 3;
            this.LblDescuento.Text = "Descuento";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Depth = 0;
            this.LblIva.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblIva.Location = new System.Drawing.Point(135, 298);
            this.LblIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(72, 19);
            this.LblIva.TabIndex = 4;
            this.LblIva.Text = "Total IVA";
            // 
            // LblTotalFactura
            // 
            this.LblTotalFactura.AutoSize = true;
            this.LblTotalFactura.Depth = 0;
            this.LblTotalFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTotalFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTotalFactura.Location = new System.Drawing.Point(135, 333);
            this.LblTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTotalFactura.Name = "LblTotalFactura";
            this.LblTotalFactura.Size = new System.Drawing.Size(98, 19);
            this.LblTotalFactura.TabIndex = 5;
            this.LblTotalFactura.Text = "Total Factura";
            // 
            // LblFechaRegistro
            // 
            this.LblFechaRegistro.AutoSize = true;
            this.LblFechaRegistro.Depth = 0;
            this.LblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaRegistro.Location = new System.Drawing.Point(473, 174);
            this.LblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaRegistro.Name = "LblFechaRegistro";
            this.LblFechaRegistro.Size = new System.Drawing.Size(109, 19);
            this.LblFechaRegistro.TabIndex = 6;
            this.LblFechaRegistro.Text = "Fecha Registro";
            // 
            // LblEstadoFactura
            // 
            this.LblEstadoFactura.AutoSize = true;
            this.LblEstadoFactura.Depth = 0;
            this.LblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEstadoFactura.Location = new System.Drawing.Point(473, 220);
            this.LblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEstadoFactura.Name = "LblEstadoFactura";
            this.LblEstadoFactura.Size = new System.Drawing.Size(110, 19);
            this.LblEstadoFactura.TabIndex = 7;
            this.LblEstadoFactura.Text = "Estado Factura";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(295, 24);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(212, 19);
            this.LblTitulo.TabIndex = 8;
            this.LblTitulo.Text = "ADMINISTRACION FACTURAS";
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(258, 142);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroFactura.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(258, 176);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 10;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(258, 218);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 11;
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Location = new System.Drawing.Point(589, 220);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFactura.TabIndex = 12;
            // 
            // dateFechaRegistro
            // 
            this.dateFechaRegistro.Location = new System.Drawing.Point(588, 173);
            this.dateFechaRegistro.Name = "dateFechaRetiro";
            this.dateFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dateFechaRegistro.TabIndex = 13;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(690, 531);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(670, 333);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(95, 23);
            this.BtnActualizar.TabIndex = 23;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtFacturaRich
            // 
            this.TxtFacturaRich.Location = new System.Drawing.Point(139, 394);
            this.TxtFacturaRich.Name = "TxtFacturaRich";
            this.TxtFacturaRich.Size = new System.Drawing.Size(527, 160);
            this.TxtFacturaRich.TabIndex = 25;
            this.TxtFacturaRich.Text = "";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.TxtFacturaRich);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dateFechaRegistro);
            this.Controls.Add(this.cmbEstadoFactura);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.TxtNumeroFactura);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblEstadoFactura);
            this.Controls.Add(this.LblFechaRegistro);
            this.Controls.Add(this.LblTotalFactura);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.LblDescuento);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblNumeroFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblNumeroFactura;
        private MaterialSkin.Controls.MaterialLabel LblCliente;
        private MaterialSkin.Controls.MaterialLabel LblEmpleado;
        private MaterialSkin.Controls.MaterialLabel LblDescuento;
        private MaterialSkin.Controls.MaterialLabel LblIva;
        private MaterialSkin.Controls.MaterialLabel LblTotalFactura;
        private MaterialSkin.Controls.MaterialLabel LblFechaRegistro;
        private MaterialSkin.Controls.MaterialLabel LblEstadoFactura;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.DateTimePicker dateFechaRegistro;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private System.Windows.Forms.RichTextBox TxtFacturaRich;
    }
}