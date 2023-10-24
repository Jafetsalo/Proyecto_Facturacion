namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmListaRolEmpleados
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
            this.dgRolEmpleados = new System.Windows.Forms.DataGridView();
            this.Id_RolEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescripcionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtRolEmpleados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgRolEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRolEmpleados
            // 
            this.dgRolEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRolEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_RolEmpleado,
            this.strNombreRol,
            this.strDescripcionRol,
            this.btnEditar,
            this.btnBorrar});
            this.dgRolEmpleados.Location = new System.Drawing.Point(67, 126);
            this.dgRolEmpleados.Name = "dgRolEmpleados";
            this.dgRolEmpleados.Size = new System.Drawing.Size(584, 244);
            this.dgRolEmpleados.TabIndex = 24;
            this.dgRolEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRolEmpleados_CellContentClick);
            // 
            // Id_RolEmpleado
            // 
            this.Id_RolEmpleado.HeaderText = "ID";
            this.Id_RolEmpleado.Name = "Id_RolEmpleado";
            this.Id_RolEmpleado.Width = 80;
            // 
            // strNombreRol
            // 
            this.strNombreRol.HeaderText = "NOMBRE DE ROL";
            this.strNombreRol.Name = "strNombreRol";
            this.strNombreRol.Width = 300;
            // 
            // strDescripcionRol
            // 
            this.strDescripcionRol.HeaderText = "DESCRIPCION DETALLE ROL";
            this.strDescripcionRol.Name = "strDescripcionRol";
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
            this.BtnBuscar.Location = new System.Drawing.Point(526, 77);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 23;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(664, 77);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 22;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(664, 399);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtRolEmpleados
            // 
            this.TxtRolEmpleados.Depth = 0;
            this.TxtRolEmpleados.Hint = "Buscar Por Rol Empleados";
            this.TxtRolEmpleados.Location = new System.Drawing.Point(61, 77);
            this.TxtRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRolEmpleados.Name = "TxtRolEmpleados";
            this.TxtRolEmpleados.PasswordChar = '\0';
            this.TxtRolEmpleados.SelectedText = "";
            this.TxtRolEmpleados.SelectionLength = 0;
            this.TxtRolEmpleados.SelectionStart = 0;
            this.TxtRolEmpleados.Size = new System.Drawing.Size(237, 23);
            this.TxtRolEmpleados.TabIndex = 20;
            this.TxtRolEmpleados.UseSystemPasswordChar = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(270, 28);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(150, 19);
            this.LblTitulo.TabIndex = 19;
            this.LblTitulo.Text = "ROL DE EMPLEADOS";
            // 
            // frmListaRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgRolEmpleados);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtRolEmpleados);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaRolEmpleados";
            this.Text = "frmListaRolEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaRolEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRolEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRolEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRolEmpleados;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_RolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescripcionRol;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}