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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                dgClientes.Rows.Add(i,$"Nombre {i} Apellido {i}", $"{i*12345}", $"{i * 12345}");
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente cliente = new frmEditarCliente();
            cliente.IdCliente = 0;
            cliente.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
                }

            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente Cliente = new frmEditarCliente();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }





        }
    }
}
