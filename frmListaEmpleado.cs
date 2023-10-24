using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Pantallas_Sistema_Herramientas_Tres
{
    public partial class frmListaEmpleado : Form
    {
        public frmListaEmpleado()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable(); 
        Cls_Empleados empleado = new Cls_Empleados();
        private void frmListaEmpleado_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            dgEmpleados.Rows.Clear();
            dt = empleado.ConsultarEmpleado();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[6].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString()); //REVISAR POR CORRESPONDENCIA ENTRE COLUMNAS AQUI Y VARIABLES EN TABLA
                }

            }
            else { MessageBox.Show("No se encontraron registros"); }

            //for (int i = 1; i <= 10; i++)
            //{
            //    dgEmpleados.Rows.Add(i, $"Nombre {i} Apellido {i}", "Developer", $"{i * 12345}", $"{i * 12345}");
            //}

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.IdEmpleado = 0;
            empleado.ShowDialog();
            llenarGrid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgEmpleados[0, posActual].Value.ToString()}");
                }

            }

            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEmpleado empleado = new frmEmpleado();
                empleado.IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());
                empleado.ShowDialog();
            }


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtEmpleado.Text != "")
            {
                dgEmpleados.Rows.Clear();
                dt = empleado.Filtrar_Empleado(TxtEmpleado.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[6].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString()); //REVISAR POR CORRESPONDENCIA ENTRE COLUMNAS AQUI Y VARIABLES EN TABLA} }

                    }
                }
            }
            else { llenarGrid(); }
            TxtEmpleado.Clear();
        }




    }
}
