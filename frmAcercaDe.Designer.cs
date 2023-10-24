namespace Pantallas_Sistema_Herramientas_Tres
{
    partial class frmAcercaDe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAcecaDe = new MaterialSkin.Controls.MaterialLabel();
            this.TxtAcercaDe = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.TxtAcercaDe);
            this.panel1.Controls.Add(this.LblAcecaDe);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 393);
            this.panel1.TabIndex = 0;
            // 
            // LblAcecaDe
            // 
            this.LblAcecaDe.AutoSize = true;
            this.LblAcecaDe.Depth = 0;
            this.LblAcecaDe.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAcecaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAcecaDe.Location = new System.Drawing.Point(31, 20);
            this.LblAcecaDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAcecaDe.Name = "LblAcecaDe";
            this.LblAcecaDe.Size = new System.Drawing.Size(293, 19);
            this.LblAcecaDe.TabIndex = 0;
            this.LblAcecaDe.Text = "ACERCA DEL SISTEMA DE FACTURACIÓN";
            // 
            // TxtAcercaDe
            // 
            this.TxtAcercaDe.Location = new System.Drawing.Point(35, 97);
            this.TxtAcercaDe.Name = "TxtAcercaDe";
            this.TxtAcercaDe.Size = new System.Drawing.Size(545, 215);
            this.TxtAcercaDe.TabIndex = 1;
            this.TxtAcercaDe.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(474, 327);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(106, 38);
            this.BtnSalir.TabIndex = 70;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcercaDe";
            this.Text = "frmAcercaDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmAcercaDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LblAcecaDe;
        private System.Windows.Forms.RichTextBox TxtAcercaDe;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
    }
}