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
    public partial class frmListaRolEmpleados : Form
    {
        Cls_Roles rol = new Cls_Roles();
        DataTable dt = new DataTable();
        public frmListaRolEmpleados()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados rolEmpleados = new frmRolEmpleados();
            rolEmpleados.IdRolEmpleado = 0;
            rolEmpleados.ShowDialog();
            llenarGrid();
        }


        private void llenarGrid()
        {
            dgRolEmpleados.Rows.Clear();
            dt = rol.ConsultarRoles();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgRolEmpleados.Rows.Add(row[0].ToString(), row[1].ToString()); //REVISAR POR CORRESPONDENCIA ENTRE COLUMNAS AQUI Y VARIABLES EN TABLA
                }

            }
            else { MessageBox.Show("No se encontraron registros"); }

            //for (int i = 1; i <= 10; i++)
            //{
            //    dgRolEmpleados.Rows.Add(i, $"Especilista {i} generalista");
            //}

        }

        private void dgRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rol.C_IdRolEmpleado = int.Parse(dgRolEmpleados[0, posActual].Value.ToString());
                    rol.Eliminar_RolEmpleado();
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

            llenarGrid();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtRolEmpleados.Text != "")
            {
                dt = new DataTable();
                dgRolEmpleados.Rows.Clear();
                dt = rol.Filtrar_Rol(TxtRolEmpleados.Text); 

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgRolEmpleados.Rows.Add(row[0].ToString(), row[1].ToString()); //REVISAR POR CORRESPONDENCIA ENTRE COLUMNAS AQUI Y VARIABLES EN TABLA} }

                    }
                }
            }
            else { llenarGrid(); }
            TxtRolEmpleados.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaRolEmpleados_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }


        //private bool esNumerico(string text)
        //{
        //    try
        //    {
        //        double x = Convert.ToDouble(text);
        //        return true;
        //    }
        //    catch (Exception ex) { return false; }

        //}
    }
}
