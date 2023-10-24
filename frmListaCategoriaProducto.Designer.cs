namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmListaCategoriaProducto
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
            this.dgCategoriaProductos = new System.Windows.Forms.DataGridView();
            this.Id_CateogriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtCategoriaPro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoriaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategoriaProductos
            // 
            this.dgCategoriaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoriaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_CateogriaProducto,
            this.strCategoriaProducto,
            this.btnEditar,
            this.btnBorrar});
            this.dgCategoriaProductos.Location = new System.Drawing.Point(60, 129);
            this.dgCategoriaProductos.Name = "dgCategoriaProductos";
            this.dgCategoriaProductos.Size = new System.Drawing.Size(584, 244);
            this.dgCategoriaProductos.TabIndex = 18;
            this.dgCategoriaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoriaProductos_CellContentClick);
            // 
            // Id_CateogriaProducto
            // 
            this.Id_CateogriaProducto.HeaderText = "ID";
            this.Id_CateogriaProducto.Name = "Id_CateogriaProducto";
            this.Id_CateogriaProducto.Width = 80;
            // 
            // strCategoriaProducto
            // 
            this.strCategoriaProducto.HeaderText = "CATEGORIA DE PRODUCTO";
            this.strCategoriaProducto.Name = "strCategoriaProducto";
            this.strCategoriaProducto.Width = 300;
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
            this.BtnBuscar.Location = new System.Drawing.Point(519, 80);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 17;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(657, 80);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(657, 402);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCategoriaPro
            // 
            this.TxtCategoriaPro.Depth = 0;
            this.TxtCategoriaPro.Hint = "Buscar Por Categoria Producto";
            this.TxtCategoriaPro.Location = new System.Drawing.Point(54, 80);
            this.TxtCategoriaPro.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCategoriaPro.Name = "TxtCategoriaPro";
            this.TxtCategoriaPro.PasswordChar = '\0';
            this.TxtCategoriaPro.SelectedText = "";
            this.TxtCategoriaPro.SelectionLength = 0;
            this.TxtCategoriaPro.SelectionStart = 0;
            this.TxtCategoriaPro.Size = new System.Drawing.Size(237, 23);
            this.TxtCategoriaPro.TabIndex = 14;
            this.TxtCategoriaPro.UseSystemPasswordChar = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(263, 31);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(363, 19);
            this.LblTitulo.TabIndex = 13;
            this.LblTitulo.Text = "ADMINISTRACION DE CATEGORIAS DE PRODUCTOS";
            // 
            // frmListaCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCategoriaProductos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtCategoriaPro);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaCategoriaProducto";
            this.Text = "frmListaCategoriaProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaCategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoriaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategoriaProductos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCategoriaPro;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_CateogriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCategoriaProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}