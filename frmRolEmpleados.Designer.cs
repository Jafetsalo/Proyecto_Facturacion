namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmRolEmpleados
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
            this.TxtDescripcionRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtIdRolDeEmpleados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtInformeRich = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TxtDescripcionRol
            // 
            this.TxtDescripcionRol.Depth = 0;
            this.TxtDescripcionRol.Hint = "Descripción Detallada Rol";
            this.TxtDescripcionRol.Location = new System.Drawing.Point(80, 131);
            this.TxtDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescripcionRol.Name = "TxtDescripcionRol";
            this.TxtDescripcionRol.PasswordChar = '\0';
            this.TxtDescripcionRol.SelectedText = "";
            this.TxtDescripcionRol.SelectionLength = 0;
            this.TxtDescripcionRol.SelectionStart = 0;
            this.TxtDescripcionRol.Size = new System.Drawing.Size(172, 23);
            this.TxtDescripcionRol.TabIndex = 73;
            this.TxtDescripcionRol.UseSystemPasswordChar = false;
            // 
            // TxtNombreRol
            // 
            this.TxtNombreRol.Depth = 0;
            this.TxtNombreRol.Hint = "Nombre Rol";
            this.TxtNombreRol.Location = new System.Drawing.Point(80, 89);
            this.TxtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreRol.Name = "TxtNombreRol";
            this.TxtNombreRol.PasswordChar = '\0';
            this.TxtNombreRol.SelectedText = "";
            this.TxtNombreRol.SelectionLength = 0;
            this.TxtNombreRol.SelectionStart = 0;
            this.TxtNombreRol.Size = new System.Drawing.Size(172, 23);
            this.TxtNombreRol.TabIndex = 72;
            this.TxtNombreRol.UseSystemPasswordChar = false;
            // 
            // TxtIdRolDeEmpleados
            // 
            this.TxtIdRolDeEmpleados.Depth = 0;
            this.TxtIdRolDeEmpleados.Hint = "";
            this.TxtIdRolDeEmpleados.Location = new System.Drawing.Point(80, 49);
            this.TxtIdRolDeEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdRolDeEmpleados.Name = "TxtIdRolDeEmpleados";
            this.TxtIdRolDeEmpleados.PasswordChar = '\0';
            this.TxtIdRolDeEmpleados.SelectedText = "";
            this.TxtIdRolDeEmpleados.SelectionLength = 0;
            this.TxtIdRolDeEmpleados.SelectionStart = 0;
            this.TxtIdRolDeEmpleados.Size = new System.Drawing.Size(75, 23);
            this.TxtIdRolDeEmpleados.TabIndex = 71;
            this.TxtIdRolDeEmpleados.UseSystemPasswordChar = false;
            // 
            // TxtInformeRich
            // 
            this.TxtInformeRich.Location = new System.Drawing.Point(80, 185);
            this.TxtInformeRich.Name = "TxtRichDatosAdicionales";
            this.TxtInformeRich.Size = new System.Drawing.Size(428, 138);
            this.TxtInformeRich.TabIndex = 70;
            this.TxtInformeRich.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(402, 378);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(106, 38);
            this.BtnSalir.TabIndex = 69;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(141, 378);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(106, 40);
            this.BtnActualizar.TabIndex = 68;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(242, 31);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(150, 19);
            this.LblTitulo.TabIndex = 74;
            this.LblTitulo.Text = "ROL DE EMPLEADOS";
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtDescripcionRol);
            this.Controls.Add(this.TxtNombreRol);
            this.Controls.Add(this.TxtIdRolDeEmpleados);
            this.Controls.Add(this.TxtInformeRich);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.Load += new System.EventHandler(this.frmRolEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescripcionRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdRolDeEmpleados;
        private System.Windows.Forms.RichTextBox TxtInformeRich;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
    }
}