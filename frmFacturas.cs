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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }
        public int IdFacturas { get; set; }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            if (IdFacturas == 0)
            {
                LblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR FACTURA";
                TxtNumeroFactura.Text = IdFacturas.ToString();
                cmbCliente.Text = "John Doe";
                cmbEmpleado.Text = "Jane Doe";
                dateFechaRegistro.Value = DateTime.Now;
                cmbEstadoFactura.Text = "Aprobada";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

  
    }
}
