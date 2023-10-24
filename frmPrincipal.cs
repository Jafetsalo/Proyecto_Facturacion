using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_Herramientas_Tres
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {   
            InitializeComponent();
        }

        private void tabOpcionesMenu_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            frmListaClientes listaClientes = new frmListaClientes();
            AbrirForm(listaClientes);
        }

        public void AbrirForm(Form formHijo) 
        {
            if (this.pnlContenedor.Controls.Count > 0) this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            frmListaProductos listaProductos = new frmListaProductos();
            AbrirForm(listaProductos);
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            frmListaCategoriaProducto categoriaProducto = new frmListaCategoriaProducto();
            AbrirForm(categoriaProducto);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas listaFacturas = new frmListaFacturas();
            AbrirForm(listaFacturas);
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            frmListaInformes listaInformes = new frmListaInformes();
            AbrirForm(listaInformes);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleado listaEmpleado = new frmListaEmpleado();
            AbrirForm(listaEmpleado);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            frmListaRolEmpleados listaRolEmpleados = new frmListaRolEmpleados();
            AbrirForm(listaRolEmpleados);
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad frmAdmin = new frmAdminSeguridad();
            AbrirForm(frmAdmin);
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (this.pnlContenedor.Controls.Count > 0) { this.pnlContenedor.Controls.RemoveAt(0); webHelp.Hide(); }
           
            webHelp.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(webHelp);
            webHelp.Show();
            
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            AbrirForm(acercaDe);

        }
    }
}
