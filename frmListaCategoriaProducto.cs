using Capa_Negocios;
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
        DataTable dt = new DataTable();
        Cls_CategoriaProducto categoriaProducto = new Cls_CategoriaProducto();
        public frmListaCategoriaProducto()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoriaProducto categoriaProductos = new frmCategoriaProducto();
            categoriaProductos.IdCategoriaProducto = 0;
            categoriaProductos.ShowDialog();
            llenarGrid();
        }


        private void llenarGrid()
        {
            dgCategoriaProductos.Rows.Clear();
            dt = categoriaProducto.Consultar_CategoriaProducto();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows) { dgCategoriaProductos.Rows.Add(row[0].ToString(), row[1].ToString()); }
            }
            else { MessageBox.Show("No se encontraron registros"); }
        }

        private void dgCategoriaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoriaProducto.C_IdCategoria = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
                    categoriaProducto.Eliminar_CategoriaProducto();
                    
                    MessageBox.Show($"BORRADO indice {e.RowIndex} ID {dgCategoriaProductos[0, posActual].Value.ToString()}");
                }

            }

            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                frmCategoriaProducto categoriaProductos = new frmCategoriaProducto();
                categoriaProductos.IdCategoriaProducto = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
                categoriaProductos.ShowDialog();
            }
            llenarGrid();


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtCategoriaPro.Text != "") 
            {
                dgCategoriaProductos.Rows.Clear();

                dt = categoriaProducto.Filtrar_CategoriaProducto(TxtCategoriaPro.Text);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows) { dgCategoriaProductos.Rows.Add(row[0].ToString(), row[1].ToString()); }
                }
               

            }
            else { llenarGrid(); }
            TxtCategoriaPro.Clear();
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
