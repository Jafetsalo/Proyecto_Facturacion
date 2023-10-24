namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmAdminSeguridad
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
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.LblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MensajeError2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnEliminarAcceso = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(243, 29);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(329, 19);
            this.LblTitulo.TabIndex = 81;
            this.LblTitulo.Text = "ADMINISTRACION DE USUARIOS DEL SISTEMA";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(452, 381);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(106, 38);
            this.BtnSalir.TabIndex = 76;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(247, 379);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(106, 40);
            this.BtnActualizar.TabIndex = 75;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.MensajeError1.SetError(this.TxtUsuario, "El campo está vacío, debe llenarlo");
            this.TxtUsuario.Hint = "Nuevo Usuario";
            this.TxtUsuario.Location = new System.Drawing.Point(247, 222);
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(172, 23);
            this.TxtUsuario.TabIndex = 79;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // TxtClave
            // 
            this.TxtClave.Depth = 0;
            this.MensajeError2.SetError(this.TxtClave, "El campo está vacío, debe llenarlo");
            this.TxtClave.Hint = "Nueva Clave";
            this.TxtClave.Location = new System.Drawing.Point(247, 278);
            this.TxtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.Size = new System.Drawing.Size(172, 23);
            this.TxtClave.TabIndex = 80;
            this.TxtClave.UseSystemPasswordChar = false;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(181, 133);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(377, 21);
            this.cmbEmpleados.TabIndex = 82;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Depth = 0;
            this.LblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEmpleado.Location = new System.Drawing.Point(41, 135);
            this.LblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.LblEmpleado.TabIndex = 83;
            this.LblEmpleado.Text = "Empleado";
            // 
            // MensajeError1
            // 
            this.MensajeError1.ContainerControl = this;
            // 
            // MensajeError2
            // 
            this.MensajeError2.ContainerControl = this;
            // 
            // BtnEliminarAcceso
            // 
            this.BtnEliminarAcceso.Depth = 0;
            this.BtnEliminarAcceso.Location = new System.Drawing.Point(452, 243);
            this.BtnEliminarAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminarAcceso.Name = "BtnEliminarAcceso";
            this.BtnEliminarAcceso.Primary = true;
            this.BtnEliminarAcceso.Size = new System.Drawing.Size(106, 40);
            this.BtnEliminarAcceso.TabIndex = 84;
            this.BtnEliminarAcceso.Text = "ELIMINAR";
            this.BtnEliminarAcceso.UseVisualStyleBackColor = true;
            this.BtnEliminarAcceso.Click += new System.EventHandler(this.BtnEliminarAcceso_Click);
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.BtnEliminarAcceso);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSeguridad";
            this.Text = "frmAdminSeguridad";
            this.Load += new System.EventHandler(this.frmAdminSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClave;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private MaterialSkin.Controls.MaterialLabel LblEmpleado;
        private System.Windows.Forms.ErrorProvider MensajeError1;
        private System.Windows.Forms.ErrorProvider MensajeError2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarAcceso;
    }
}