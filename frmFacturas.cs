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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }
        public int IdFactura { get; set; }
        public Cls_Factura Factura = new Cls_Factura();
        public DataTable dt = new DataTable();

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (IdFactura == 0)
            {
                LblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR FACTURA";
                llenarCampos();
                
            }
        }

        private void llenarCombo()
        {

            cmbCliente.DataSource = Factura.ConsultarCliente();
            cmbCliente.DisplayMember = "StrNombre";
            cmbCliente.ValueMember = "IdCliente";


            cmbEmpleado.DataSource = Factura.ConsultarEmpleado();
            cmbEmpleado.DisplayMember = "StrNombre";
            cmbEmpleado.ValueMember = "IdEmpleado";


            cmbEstadoFactura.DataSource = Factura.ConsultarEstadoFactura();
            cmbEstadoFactura.DisplayMember = "StrDescripcion";
            cmbEstadoFactura.ValueMember = "IdEstadoFactura";
        }

        private void llenarCampos()
        {
            dt = Factura.ConsultarFactura(IdFactura);
            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows) 
                {
                    TxtNumeroFactura.Text = IdFactura.ToString();
                    dateFechaRegistro.Value = DateTime.Parse(row[1].ToString());
                    cmbCliente.SelectedValue = row[2].ToString();
                    cmbEmpleado.SelectedValue = row[3].ToString();
                    TxtDescuento.Text = row[4].ToString();
                    TxtImpuesto.Text = row[5].ToString();
                    TxtTotalFactura.Text = row[6].ToString();
                    cmbEstadoFactura.SelectedValue = row[7].ToString();


                }
            }

        }




        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro Desea Salir de la Edición de Factura", "PREGUNTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK) { this.Close(); }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
            Guardar();
        }

        private void Guardar()
        {
            string mensaje = "";
            if (validarFormulario()) 
            {
                Factura.C_IdFactura = IdFactura;
                Factura.C_DtmFecha = dateFechaRegistro.Value.Date.ToShortDateString();
                Factura.C_IdCliente = int.Parse(cmbCliente.SelectedValue.ToString());
                Factura.C_IdEmpleado = int.Parse(cmbEmpleado.SelectedValue.ToString());
                Factura.C_NumDescuento = float.Parse(TxtDescuento.Text);
                Factura.C_NumImpuesto = float.Parse(TxtImpuesto.Text);
                Factura.C_NumValorTotal = float.Parse(TxtTotalFactura.Text);
                Factura.C_IdEstado = int.Parse(cmbEstadoFactura.SelectedValue.ToString());
                Factura.C_StrUsuarioModifica = "Administrador";
                mensaje = Factura.ActualizarFactura();
                MessageBox.Show(mensaje);
            }
        }

        private bool validarFormulario()
        {
            bool errorCampos = true;
            if (!esNumerico(TxtTotalFactura.Text))
            { MensajeError.SetError(TxtTotalFactura, "Atención: Debe llenar Solo Números En Total Factura"); TxtTotalFactura.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtTotalFactura, ""); }

            return errorCampos;
        }

        private bool esNumerico(string text)
        {
            try
            {
                double x = Convert.ToDouble(text);
                return true;
            }
            catch (Exception ex) { return false; }

        }
    }
}
