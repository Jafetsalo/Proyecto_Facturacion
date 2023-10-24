namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmEmpleado
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
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtRichDatosAdicionales = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.LblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.LblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(577, 109);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(199, 20);
            this.dateFechaInicio.TabIndex = 60;
            // 
            // LblFechaIngreso
            // 
            this.LblFechaIngreso.AutoSize = true;
            this.LblFechaIngreso.Depth = 0;
            this.LblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaIngreso.Location = new System.Drawing.Point(462, 109);
            this.LblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaIngreso.Name = "LblFechaIngreso";
            this.LblFechaIngreso.Size = new System.Drawing.Size(103, 19);
            this.LblFechaIngreso.TabIndex = 59;
            this.LblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(184, 9);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(247, 19);
            this.LblTitulo.TabIndex = 58;
            this.LblTitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // TxtRichDatosAdicionales
            // 
            this.TxtRichDatosAdicionales.Location = new System.Drawing.Point(421, 249);
            this.TxtRichDatosAdicionales.Name = "TxtRichDatosAdicionales";
            this.TxtRichDatosAdicionales.Size = new System.Drawing.Size(428, 138);
            this.TxtRichDatosAdicionales.TabIndex = 57;
            this.TxtRichDatosAdicionales.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(682, 453);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(106, 38);
            this.BtnSalir.TabIndex = 56;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(421, 453);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(106, 40);
            this.BtnActualizar.TabIndex = 55;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dateFechaRetiro
            // 
            this.dateFechaRetiro.Location = new System.Drawing.Point(577, 135);
            this.dateFechaRetiro.Name = "dateFechaRetiro";
            this.dateFechaRetiro.Size = new System.Drawing.Size(200, 20);
            this.dateFechaRetiro.TabIndex = 54;
            // 
            // LblFechaRetiro
            // 
            this.LblFechaRetiro.AutoSize = true;
            this.LblFechaRetiro.Depth = 0;
            this.LblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaRetiro.Location = new System.Drawing.Point(462, 135);
            this.LblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaRetiro.Name = "LblFechaRetiro";
            this.LblFechaRetiro.Size = new System.Drawing.Size(93, 19);
            this.LblFechaRetiro.TabIndex = 50;
            this.LblFechaRetiro.Text = "Fecha Retiro";
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Depth = 0;
            this.TxtIdEmpleado.Hint = "";
            this.TxtIdEmpleado.Location = new System.Drawing.Point(62, 100);
            this.TxtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.PasswordChar = '\0';
            this.TxtIdEmpleado.SelectedText = "";
            this.TxtIdEmpleado.SelectionLength = 0;
            this.TxtIdEmpleado.SelectionStart = 0;
            this.TxtIdEmpleado.Size = new System.Drawing.Size(75, 23);
            this.TxtIdEmpleado.TabIndex = 64;
            this.TxtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Teléfono";
            this.TxtTelefono.Location = new System.Drawing.Point(62, 296);
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(172, 23);
            this.TxtTelefono.TabIndex = 69;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "E-mail";
            this.TxtEmail.Location = new System.Drawing.Point(62, 336);
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(172, 23);
            this.TxtEmail.TabIndex = 68;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(62, 203);
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(172, 23);
            this.TxtDocumento.TabIndex = 67;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Dirección";
            this.TxtDireccion.Location = new System.Drawing.Point(62, 249);
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(172, 23);
            this.TxtDireccion.TabIndex = 66;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Depth = 0;
            this.TxtNombreEmpleado.Hint = "Nombre Empleado";
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(62, 161);
            this.TxtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.PasswordChar = '\0';
            this.TxtNombreEmpleado.SelectedText = "";
            this.TxtNombreEmpleado.SelectionLength = 0;
            this.TxtNombreEmpleado.SelectionStart = 0;
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(172, 23);
            this.TxtNombreEmpleado.TabIndex = 65;
            this.TxtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // cmbRolEmpleado
            // 
            this.cmbRolEmpleado.FormattingEnabled = true;
            this.cmbRolEmpleado.Location = new System.Drawing.Point(576, 82);
            this.cmbRolEmpleado.Name = "cmbRolEmpleado";
            this.cmbRolEmpleado.Size = new System.Drawing.Size(200, 21);
            this.cmbRolEmpleado.TabIndex = 71;
            // 
            // LblRolEmpleado
            // 
            this.LblRolEmpleado.AutoSize = true;
            this.LblRolEmpleado.Depth = 0;
            this.LblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRolEmpleado.Location = new System.Drawing.Point(462, 84);
            this.LblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRolEmpleado.Name = "LblRolEmpleado";
            this.LblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.LblRolEmpleado.TabIndex = 70;
            this.LblRolEmpleado.Text = "Rol Empleado";
            // 
            // LblDatosAdicionales
            // 
            this.LblDatosAdicionales.AutoSize = true;
            this.LblDatosAdicionales.Depth = 0;
            this.LblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDatosAdicionales.Location = new System.Drawing.Point(417, 218);
            this.LblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDatosAdicionales.Name = "LblDatosAdicionales";
            this.LblDatosAdicionales.Size = new System.Drawing.Size(156, 19);
            this.LblDatosAdicionales.TabIndex = 72;
            this.LblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 513);
            this.Controls.Add(this.LblDatosAdicionales);
            this.Controls.Add(this.cmbRolEmpleado);
            this.Controls.Add(this.LblRolEmpleado);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.LblFechaIngreso);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtRichDatosAdicionales);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dateFechaRetiro);
            this.Controls.Add(this.LblFechaRetiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private MaterialSkin.Controls.MaterialLabel LblFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.RichTextBox TxtRichDatosAdicionales;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private System.Windows.Forms.DateTimePicker dateFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel LblFechaRetiro;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreEmpleado;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel LblRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel LblDatosAdicionales;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}