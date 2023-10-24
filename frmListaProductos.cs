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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.IdProducto = 0;
            productos.ShowDialog();
        }


        private void llenarGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgProductos.Rows.Add(i, $"Articulo {i} Código {i}", $"{i * 12345}", $"{i * 12345}");
            }

        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgProductos[0, posActual].Value.ToString()}");
                }

            }

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                frmProductos productos = new frmProductos();
                productos.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                productos.ShowDialog();
            }



        }


    }
}
