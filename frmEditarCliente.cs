using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_Herramientas_Tres
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }
        Cls_Clientes cliente = new Cls_Clientes();
        DataTable dt = new DataTable();
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else 
            {
                LblTitulo.Text = "MODIFICAR CLIENTE";
                llenarCampos();
            }


        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            MessageBox.Show("Datos Actualizados");


        }

        private void Guardar() 
        {
            string mensaje = "";
            if (validarFormulario()) 
            {
                cliente.C_IdCliente = IdCliente;
                cliente.C_StrNombre = TxtNombre.Text;
                cliente.C_NumDocumento = int.Parse(TxtDocumento.Text);
                cliente.C_StrDireccion = TxtDireccion.Text;
                cliente.C_StrTelefono = TxtTelefono.Text;
                cliente.C_StrEmail = TxtEmail.Text;
                cliente.C_StrUsuarioModifica = "Administrador";
                mensaje = cliente.ActualizarCliente();
                MessageBox.Show(mensaje);
            }

        }

        private bool validarFormulario()
        {
            bool errorCampos = true;
            if (TxtNombre.Text == string.Empty)
            { MensajeError.SetError(TxtNombre, "Atención: Ingresar Nombre Cliente"); TxtNombre.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtNombre, ""); }


            if (!esNumerico(TxtDocumento.Text))
            { MensajeError.SetError(TxtDocumento, "Atención: Solo Números En Documento"); TxtDocumento.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtDocumento, ""); }

            if (TxtDocumento.Text == string.Empty)
            { MensajeError.SetError(TxtDocumento, "Atención: Ingresar Documento Empleado"); TxtDocumento.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtDocumento, ""); }


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
        private void BtnSalir_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Seguro Desea Salir de la Edición de Empleado", "PREGUNTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void llenarCampos() 
        {
            dt = cliente.ConsultarCliente(IdCliente);
            if (dt != null) 
            {
                foreach (DataRow row in dt.Rows)
                {
                    TxtIdCliente.Text = row[0].ToString();
                    TxtNombre.Text = row[1].ToString();
                    TxtDocumento.Text = row[2].ToString();
                    TxtDireccion.Text = row[3].ToString();
                    TxtTelefono.Text = row[4].ToString();
                    TxtEmail.Text = row[5].ToString();
                }
                    
            }
        }
    }
}
