namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmCategoriaProducto
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
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreCategoriaProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(203, 52);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(308, 19);
            this.LblTitulo.TabIndex = 33;
            this.LblTitulo.Text = "ADMINISTRACION CATEGORIA PRODUCTOS";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Depth = 0;
            this.TxtIdProducto.Hint = "";
            this.TxtIdProducto.Location = new System.Drawing.Point(69, 110);
            this.TxtIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.PasswordChar = '\0';
            this.TxtIdProducto.SelectedText = "";
            this.TxtIdProducto.SelectionLength = 0;
            this.TxtIdProducto.SelectionStart = 0;
            this.TxtIdProducto.Size = new System.Drawing.Size(75, 23);
            this.TxtIdProducto.TabIndex = 28;
            this.TxtIdProducto.UseSystemPasswordChar = false;
            // 
            // TxtNombreCategoriaProducto
            // 
            this.TxtNombreCategoriaProducto.Depth = 0;
            this.TxtNombreCategoriaProducto.Hint = "Nombre Categoria Producto";
            this.TxtNombreCategoriaProducto.Location = new System.Drawing.Point(146, 146);
            this.TxtNombreCategoriaProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreCategoriaProducto.Name = "TxtNombreCategoriaProducto";
            this.TxtNombreCategoriaProducto.PasswordChar = '\0';
            this.TxtNombreCategoriaProducto.SelectedText = "";
            this.TxtNombreCategoriaProducto.SelectionLength = 0;
            this.TxtNombreCategoriaProducto.SelectionStart = 0;
            this.TxtNombreCategoriaProducto.Size = new System.Drawing.Size(249, 23);
            this.TxtNombreCategoriaProducto.TabIndex = 23;
            this.TxtNombreCategoriaProducto.UseSystemPasswordChar = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(499, 375);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 22;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(331, 375);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(95, 23);
            this.BtnActualizar.TabIndex = 21;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // frmCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.TxtNombreCategoriaProducto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriaProducto";
            this.Text = "frmCategoriaProducto";
            this.Load += new System.EventHandler(this.frmCategoriaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreCategoriaProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
    }
}