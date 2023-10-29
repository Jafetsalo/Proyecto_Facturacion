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
    public partial class frmListaProductos : Form
    {
        Cls_Producto producto = new Cls_Producto();
        DataTable dt = new DataTable();

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
            llenarGrid();
        }


        private void llenarGrid()
        {
            dgProductos.Rows.Clear();
            dt = producto.ConsultarProducto();
            if (dt != null) 
            {
                foreach (DataRow row in dt.Rows) 
                {
                    dgProductos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[8].ToString(), row[5].ToString(), row[7].ToString(), row[6].ToString());
                }
                
            }
            else { MessageBox.Show("No se encontraron registros"); }
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    producto.C_IdProducto = int.Parse(dgProductos[0,posActual].Value.ToString());
                    producto.EliminarProducto();
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgProductos[0, posActual].Value.ToString()}");
                }

            }

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                frmProductos formularioProducto = new frmProductos();
                formularioProducto.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                formularioProducto.ShowDialog();
            }

            llenarGrid();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtProducto.Text != "")
            {
                dgProductos.Rows.Clear();
                dt = producto.Filtrar_Producto(TxtProducto.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgProductos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[8].ToString(), row[5].ToString(), row[7].ToString(), row[6].ToString());
                    }
                }
            }
            else { llenarGrid(); }
            TxtProducto.Clear();
            
        }
    }
}
