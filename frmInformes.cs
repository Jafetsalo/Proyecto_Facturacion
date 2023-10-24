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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }
        public int IdInformes { get; set; }

        private void frmInformes_Load(object sender, EventArgs e)
        {
            if (IdInformes == 0)
            {
                LblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR FACTURA";
               cmbInforme.Text = IdInformes.ToString();
                TxtInformeRich.Text += "John Doe Compras Mensuales al";
                
                dateFechaRegistro.Value = DateTime.Now;
                dateFechaInicio.Value = DateTime.Now;
                cmbEstadoFactura.Text = "Aprobada";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnGenerarInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe Generado");
        }

        
        
    }
}
