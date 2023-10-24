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
    public partial class frmListaCategoriaProducto : Form
    {
        public frmListaCategoriaProducto()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoriaProducto categoriaProductos = new frmCategoriaProducto();
            categoriaProductos.IdCategoriaProducto = 0;
            categoriaProductos.ShowDialog();
        }


        private void llenarGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgCategoriaProductos.Rows.Add(i, $"Categoría Código {i}");
            }

        }

        private void dgCategoriaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgCategoriaProductos[0, posActual].Value.ToString()}");
                }

            }

            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                frmCategoriaProducto categoriaProductos = new frmCategoriaProducto();
                categoriaProductos.IdCategoriaProducto = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
                categoriaProductos.ShowDialog();
            }



        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaCategoriaProducto_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

    }
}
