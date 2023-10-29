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
    public partial class frmListaFacturas : Form
    {
        public Cls_Factura Factura = new Cls_Factura();
        public DataTable dt = new DataTable();
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.IdFactura = 0;
            facturas.ShowDialog();
            llenarGrid();
        }


        private void llenarGrid()
        {
            dgFactura.Rows.Clear();
            dt = Factura.ConsultarFactura();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgFactura.Rows.Add(row[0].ToString(), row[11].ToString(), row[19].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[1].ToString(), row[12].ToString());
                }
            }
            else { MessageBox.Show("No se encontraron registros"); }

        }

        private void dgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgFactura.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgFactura.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Factura.C_IdFactura = int.Parse(dgFactura[0,posActual].Value.ToString());
                    Factura.EliminarFactura();
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgFactura[0, posActual].Value.ToString()}");
                }

            }

            if (dgFactura.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFactura.CurrentRow.Index;
                frmFacturas facturas = new frmFacturas();
                facturas.IdFactura = int.Parse(dgFactura[0, posActual].Value.ToString());
                facturas.ShowDialog();
            }

            llenarGrid();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (TxtFactura.Text != "")
            {
                dgFactura.Rows.Clear();
                dt = Factura.Filtrar_Factura(TxtFactura.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgFactura.Rows.Add(row[0].ToString(), row[11].ToString(), row[19].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[1].ToString(), row[12].ToString());

                    }
                }
            }
            else { llenarGrid(); }
            TxtFactura.Clear();

        }
    }
}
