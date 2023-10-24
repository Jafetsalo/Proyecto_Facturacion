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
    public partial class frmListaRolEmpleados : Form
    {
        public frmListaRolEmpleados()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados rolEmpleados = new frmRolEmpleados();
            rolEmpleados.IdRolEmpleado = 0;
            rolEmpleados.ShowDialog();
        }


        private void llenarGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgRolEmpleados.Rows.Add(i, $"Especilista {i} generalista");
            }

        }

        private void dgRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgRolEmpleados[0, posActual].Value.ToString()}");
                }

            }

            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                frmRolEmpleados rolEmpleados = new frmRolEmpleados();
                rolEmpleados.IdRolEmpleado = int.Parse(dgRolEmpleados[0, posActual].Value.ToString());
                rolEmpleados.ShowDialog();
            }



        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaRolEmpleados_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

    }
}
