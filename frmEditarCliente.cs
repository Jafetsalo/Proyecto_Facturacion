using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_Herramientas_Tres
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else 
            {
                LblTitulo.Text = "MODIFICAR CLIENTE";
                TxtIdCliente.Text = IdCliente.ToString();
                TxtNombre.Text = "nombre 1 Apellido";
                TxtDocumento.Text = "123456789";
                TxtDireccion.Text = "Dirección del cliente";
                TxtTelefono.Text = "0987654321";
                TxtEmail.Text = "abc@ejemplo.com";
            }


        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
