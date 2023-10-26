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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }
        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (IdEmpleado == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR EMPLEADO";
                llenarCampos();
            }


        }

        private void llenarCombo() 
        {
            cmbRolEmpleado.DataSource = empleado.ConsultarRol();
            cmbRolEmpleado.DisplayMember = "StrDescripcion";
            cmbRolEmpleado.ValueMember = "IdRolEmpleado";
        }
        private void llenarCampos() 
        {
            dt = empleado.ConsultarEmpleado(IdEmpleado);
            if (dt.Rows.Count > 0) 
            { 
                foreach (DataRow row in dt.Rows) 
                {
                    TxtIdEmpleado.Text = row[0].ToString();
                    TxtNombreEmpleado.Text = row[1].ToString();
                    TxtDocumento.Text = row[2].ToString();
                    TxtDireccion.Text = row[3].ToString();
                    TxtTelefono.Text = row[4].ToString();
                    TxtEmail.Text = row[5].ToString();
                    cmbRolEmpleado.SelectedValue = row[6].ToString();
                    dateFechaInicio.Text = row[7].ToString();
                    dateFechaRetiro.Text = row[8].ToString();
                    TxtRichDatosAdicionales.Text = row[9].ToString();
                }
            }


        }

        private void Guardar() 
        {
            string mensaje = ""; 
            if (validarFormulario()) 
            {
                empleado.C_IdEmpleado = IdEmpleado;
                empleado.C_StrNombre = TxtNombreEmpleado.Text;
                empleado.C_NumDocumento = double.Parse(TxtDocumento.Text);
                empleado.C_StrDireccion = TxtDireccion.Text;
                empleado.C_StrTelefono = TxtTelefono.Text;
                empleado.C_StrEmail = TxtEmail.Text;
                empleado.C_IdRolEmpleado = int.Parse(cmbRolEmpleado.SelectedValue.ToString());
                empleado.C_DtmIngreso = dateFechaInicio.Value.Date.ToShortDateString(); //NOT SURE ABOUT THIS. PLEASE CHECK THIS LATER
                empleado.C_DtmRetiro = dateFechaRetiro.Value.Date.ToShortDateString();
                empleado.C_StrDatosAdicionales = TxtRichDatosAdicionales.Text;
                empleado.C_StrUsuarioModifico = "Administrador";
                
                mensaje = empleado.ActualizarEmpleado();
                MessageBox.Show(mensaje);
            }

        }

        private bool validarFormulario() //IN PROGRESS
        {
            bool errorCampos = true;
            if (TxtNombreEmpleado.Text == string.Empty) 
            {MensajeError.SetError(TxtNombreEmpleado, "Atención: Ingresar Nombre Empleado"); TxtNombreEmpleado.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtNombreEmpleado,""); }

            if (TxtDocumento.Text == string.Empty) 
            { MensajeError.SetError(TxtDocumento, "Atención: Ingresar Documento Empleado"); TxtDocumento.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtDocumento, ""); }

            if (!esNumerico(TxtDocumento.Text)) 
            { MensajeError.SetError(TxtDocumento, "Atención: Solo Números En Documento"); TxtDocumento.Focus(); errorCampos = false; }
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            
            MessageBox.Show("Datos Actualizados");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro Desea Salir de la Edición de Empleado", "PREGUNTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK) { this.Close(); }
                
        }

    }
}
