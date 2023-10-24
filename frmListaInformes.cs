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
    public partial class frmListaInformes : Form
    {
        public frmListaInformes()
        {
            InitializeComponent();
        }

        private void frmListaInformes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            informes.IdInformes = 0;
            informes.ShowDialog();
        }


        private void llenarGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgInformeFacturacion.Rows.Add(i, $"Informe Código {i}");
            }

        }

        private void dgInformeFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgInformeFacturacion.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgInformeFacturacion.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgInformeFacturacion[0, posActual].Value.ToString()}");
                }

            }

            if (dgInformeFacturacion.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgInformeFacturacion.CurrentRow.Index;
                frmInformes categoriaProductos = new frmInformes();
                categoriaProductos.IdInformes = int.Parse(dgInformeFacturacion[0, posActual].Value.ToString());
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


    }
}
