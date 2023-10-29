using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pantallas_Sistema_Herramientas_Tres
{
    public partial class frmListaClientes : Form
    {
        DataTable dt = new DataTable();
        Cls_Clientes cliente = new Cls_Clientes();

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
            dgClientes.Rows.Clear();
            dt = cliente.ConsultarCliente();

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[4].ToString(), row[3].ToString(), row[2].ToString());//ID CLIENTE TELEFONO DOCUMENTO
                }
            }
            else { MessageBox.Show("No se encontraron registros"); }


        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente formularioCliente = new frmEditarCliente();
            formularioCliente.IdCliente = 0;
            formularioCliente.ShowDialog();
            llenarGrid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    cliente.C_IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                    cliente.EliminarCliente();
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
                }

            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente formularioCliente = new frmEditarCliente();
                formularioCliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                formularioCliente.ShowDialog();
            }


            llenarGrid();


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (TxtCliente.Text != "") 
            {
                dgClientes.Rows.Clear();
                dt = cliente.Filtrar_Cliente(TxtCliente.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[4].ToString(), row[3].ToString(), row[2].ToString());
                    }

                }
                
            }
            else { llenarGrid();}
            TxtCliente.Clear();
        }
    }
}
