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
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.IdFacturas = 0;
            facturas.ShowDialog();
        }


        private void llenarGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgFactura.Rows.Add(i, i, "John Doe", "Jane Doe", i, i, $"Articulo {i} Código {i}", $"{i * 12345}", $"{i * 12345}");
            }

        }

        private void dgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgFactura.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgFactura.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgFactura[0, posActual].Value.ToString()}");
                }

            }

            if (dgFactura.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFactura.CurrentRow.Index;
                frmFacturas facturas = new frmFacturas();
                facturas.IdFacturas = int.Parse(dgFactura[0, posActual].Value.ToString());
                facturas.ShowDialog();
            }



        }


    }
}
