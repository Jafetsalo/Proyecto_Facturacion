namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmProductos
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
            this.components = new System.ComponentModel.Container();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtIdProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.LblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(466, 366);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(298, 366);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(95, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Depth = 0;
            this.TxtIdProducto.Hint = "";
            this.TxtIdProducto.Location = new System.Drawing.Point(36, 101);
            this.TxtIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.PasswordChar = '\0';
            this.TxtIdProducto.SelectedText = "";
            this.TxtIdProducto.SelectionLength = 0;
            this.TxtIdProducto.SelectionStart = 0;
            this.TxtIdProducto.Size = new System.Drawing.Size(75, 23);
            this.TxtIdProducto.TabIndex = 15;
            this.TxtIdProducto.UseSystemPasswordChar = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio Venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(113, 272);
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(172, 23);
            this.TxtPrecioVenta.TabIndex = 14;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Depth = 0;
            this.TxtCantidadStock.Hint = "Cantidad Stock";
            this.TxtCantidadStock.Location = new System.Drawing.Point(113, 312);
            this.TxtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.PasswordChar = '\0';
            this.TxtCantidadStock.SelectedText = "";
            this.TxtCantidadStock.SelectionLength = 0;
            this.TxtCantidadStock.SelectionStart = 0;
            this.TxtCantidadStock.Size = new System.Drawing.Size(172, 23);
            this.TxtCantidadStock.TabIndex = 13;
            this.TxtCantidadStock.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "Codigo Referencia";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(113, 179);
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(172, 23);
            this.TxtCodigoReferencia.TabIndex = 12;
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Depth = 0;
            this.TxtPrecioCompra.Hint = "Precio Compra";
            this.TxtPrecioCompra.Location = new System.Drawing.Point(113, 225);
            this.TxtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PasswordChar = '\0';
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.SelectionLength = 0;
            this.TxtPrecioCompra.SelectionStart = 0;
            this.TxtPrecioCompra.Size = new System.Drawing.Size(172, 23);
            this.TxtPrecioCompra.TabIndex = 11;
            this.TxtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Depth = 0;
            this.TxtNombreProducto.Hint = "Nombre Producto";
            this.TxtNombreProducto.Location = new System.Drawing.Point(113, 137);
            this.TxtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.PasswordChar = '\0';
            this.TxtNombreProducto.SelectedText = "";
            this.TxtNombreProducto.SelectionLength = 0;
            this.TxtNombreProducto.SelectionStart = 0;
            this.TxtNombreProducto.Size = new System.Drawing.Size(172, 23);
            this.TxtNombreProducto.TabIndex = 10;
            this.TxtNombreProducto.UseSystemPasswordChar = false;
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta Imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(476, 191);
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(172, 23);
            this.TxtRutaImagen.TabIndex = 17;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // TxtDetalleProducto
            // 
            this.TxtDetalleProducto.Location = new System.Drawing.Point(476, 247);
            this.TxtDetalleProducto.Name = "TxtDetalleProducto";
            this.TxtDetalleProducto.Size = new System.Drawing.Size(222, 88);
            this.TxtDetalleProducto.TabIndex = 18;
            this.TxtDetalleProducto.Text = "";
            // 
            // LblDetallesProducto
            // 
            this.LblDetallesProducto.AutoSize = true;
            this.LblDetallesProducto.Depth = 0;
            this.LblDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDetallesProducto.Location = new System.Drawing.Point(473, 226);
            this.LblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDetallesProducto.Name = "LblDetallesProducto";
            this.LblDetallesProducto.Size = new System.Drawing.Size(129, 19);
            this.LblDetallesProducto.TabIndex = 19;
            this.LblDetallesProducto.Text = "Detalles Producto";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(170, 44);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(223, 19);
            this.LblTitulo.TabIndex = 20;
            this.LblTitulo.Text = "ADMINISTRACION PRODUCTOS";
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(477, 138);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaProducto.TabIndex = 21;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCategoriaProducto);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblDetallesProducto);
            this.Controls.Add(this.TxtDetalleProducto);
            this.Controls.Add(this.TxtRutaImagen);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.TxtCantidadStock);
            this.Controls.Add(this.TxtCodigoReferencia);
            this.Controls.Add(this.TxtPrecioCompra);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRutaImagen;
        private System.Windows.Forms.RichTextBox TxtDetalleProducto;
        private MaterialSkin.Controls.MaterialLabel LblDetallesProducto;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.ComboBox cmbCategoriaProducto;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}