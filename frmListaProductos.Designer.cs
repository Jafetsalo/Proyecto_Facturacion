namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmListaProductos
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
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCodigoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRutaImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetallesProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.strProducto,
            this.strCodigoReferencia,
            this.intPrecioCompra,
            this.intPrecioVenta,
            this.intCantidadStock,
            this.txtCategoriaProducto,
            this.txtRutaImagen,
            this.txtDetallesProducto,
            this.btnEditar,
            this.btnBorrar});
            this.dgProductos.Location = new System.Drawing.Point(12, 129);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(686, 244);
            this.dgProductos.TabIndex = 12;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "ID";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Width = 80;
            // 
            // strProducto
            // 
            this.strProducto.HeaderText = "PRODUCTO";
            this.strProducto.Name = "strProducto";
            this.strProducto.Width = 300;
            // 
            // strCodigoReferencia
            // 
            this.strCodigoReferencia.HeaderText = "CODIGO REFERENCIA";
            this.strCodigoReferencia.Name = "strCodigoReferencia";
            // 
            // intPrecioCompra
            // 
            this.intPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.intPrecioCompra.Name = "intPrecioCompra";
            // 
            // intPrecioVenta
            // 
            this.intPrecioVenta.HeaderText = "PRECIO VENTA";
            this.intPrecioVenta.Name = "intPrecioVenta";
            // 
            // intCantidadStock
            // 
            this.intCantidadStock.HeaderText = "CANTIDAD DE STOCK";
            this.intCantidadStock.Name = "intCantidadStock";
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.HeaderText = "CATEGORÍA PRODUCTO";
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.HeaderText = "RUTA IMAGEN";
            this.txtRutaImagen.Name = "txtRutaImagen";
            // 
            // txtDetallesProducto
            // 
            this.txtDetallesProducto.HeaderText = "DETALLES PRODUCTO";
            this.txtDetallesProducto.Name = "txtDetallesProducto";
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
            // TxtProducto
            // 
            this.TxtProducto.Depth = 0;
            this.TxtProducto.Hint = "Buscar Por Producto";
            this.TxtProducto.Location = new System.Drawing.Point(6, 80);
            this.TxtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.PasswordChar = '\0';
            this.TxtProducto.SelectedText = "";
            this.TxtProducto.SelectionLength = 0;
            this.TxtProducto.SelectionStart = 0;
            this.TxtProducto.Size = new System.Drawing.Size(237, 23);
            this.TxtProducto.TabIndex = 8;
            this.TxtProducto.UseSystemPasswordChar = false;
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
            this.LblTitulo.Size = new System.Drawing.Size(246, 19);
            this.LblTitulo.TabIndex = 7;
            this.LblTitulo.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.Text = "CRUD LISTA PRODUCTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigoReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRutaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDetallesProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProducto;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
    }
}