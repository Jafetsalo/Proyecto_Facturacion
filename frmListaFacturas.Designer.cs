namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmListaFacturas
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
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.Id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstadoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFactura
            // 
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Factura,
            this.strCliente,
            this.strEmpleado,
            this.intDescuento,
            this.intIVA,
            this.intTotalFactura,
            this.strEstadoFactura,
            this.dateFechaRetiro,
            this.strDocumento,
            this.btnEditar,
            this.btnBorrar});
            this.dgFactura.Location = new System.Drawing.Point(6, 129);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.Size = new System.Drawing.Size(788, 249);
            this.dgFactura.TabIndex = 12;
            this.dgFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFactura_CellContentClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Location = new System.Drawing.Point(471, 80);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 11;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(609, 80);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 10;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(609, 402);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // TxtFactura
            // 
            this.TxtFactura.Depth = 0;
            this.TxtFactura.Hint = "Buscar Por Factura";
            this.TxtFactura.Location = new System.Drawing.Point(6, 80);
            this.TxtFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.PasswordChar = '\0';
            this.TxtFactura.SelectedText = "";
            this.TxtFactura.SelectionLength = 0;
            this.TxtFactura.SelectionStart = 0;
            this.TxtFactura.Size = new System.Drawing.Size(237, 23);
            this.TxtFactura.TabIndex = 8;
            this.TxtFactura.UseSystemPasswordChar = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(244, 26);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(235, 19);
            this.LblTitulo.TabIndex = 7;
            this.LblTitulo.Text = "ADMINISTRACION DE FACTURAS";
            // 
            // Id_Factura
            // 
            this.Id_Factura.HeaderText = "ID FACTURA";
            this.Id_Factura.Name = "Id_Factura";
            this.Id_Factura.Width = 80;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 300;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "EMPLEADO";
            this.strEmpleado.Name = "strEmpleado";
            // 
            // intDescuento
            // 
            this.intDescuento.HeaderText = "DESCUENTO";
            this.intDescuento.Name = "intDescuento";
            // 
            // intIVA
            // 
            this.intIVA.HeaderText = "TOTAL IVA";
            this.intIVA.Name = "intIVA";
            // 
            // intTotalFactura
            // 
            this.intTotalFactura.HeaderText = "TOTAL FACTURA";
            this.intTotalFactura.Name = "intTotalFactura";
            // 
            // strEstadoFactura
            // 
            this.strEstadoFactura.HeaderText = "ESTADO FACTURA";
            this.strEstadoFactura.Name = "strEstadoFactura";
            // 
            // dateFechaRetiro
            // 
            this.dateFechaRetiro.HeaderText = "FECHA REGISTRO";
            this.dateFechaRetiro.Name = "dateFechaRetiro";
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.Name = "strDocumento";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgFactura);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFactura;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFactura;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEstadoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}