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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        Cls_AdminSeguridad AccesoSeguridadEmpleado = new Cls_AdminSeguridad();


        private void LlenarComboEmpleados()
        {
            cmbEmpleados.DataSource = AccesoSeguridadEmpleado.ConsultarEmpleados();
            cmbEmpleados.ValueMember = "IdEmpleado";
            cmbEmpleados.DisplayMember = "StrNombre";
            //for (int i = 1; i <= 10; i++)
            //{
            //    cmbEmpleados.Items.Add("Empleado " + i.ToString());
            //}

        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleados();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)//NO COMPLETO PENDIENTE POR GENERAR
        {
                Guardar();
               
        }

        private bool ValidarAcceso() 
        {
            bool errorCampos = true;
            if ((TxtClave.Text != string.Empty) && (TxtUsuario.Text != string.Empty)) 
            { errorCampos = true; } 
            else { errorCampos = false; MessageBox.Show("Campos Usuario o Clave están vacíos", "Aviso"); }
            return errorCampos;
        }

        private void Guardar()
        {
            string mensaje = "";
            if (ValidarAcceso() == true) 
            {
                AccesoSeguridadEmpleado.C_IdEmpleado = int.Parse(cmbEmpleados.SelectedValue.ToString());
                AccesoSeguridadEmpleado.C_StrUsuario = TxtUsuario.Text;
                AccesoSeguridadEmpleado.C_StrClave = TxtClave.Text;
                AccesoSeguridadEmpleado.C_StrUsuarioModifico = "Admin";
                mensaje = AccesoSeguridadEmpleado.Actualizar_AccesoSeguridadEmpleado();
                MessageBox.Show(mensaje);

            }

            TxtClave.Clear();
            TxtUsuario.Clear();

        }

        //private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TxtUsuario.Text)) { e.Cancel = true; errorProvider1.SetError(TxtUsuario, "Obligatorio llenar esta información");  }
        //    else { e.Cancel = false; errorProvider1.SetError(TxtUsuario, ""); }
        //}

        //private void TxtClave_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TxtClave.Text)) { e.Cancel = true; errorProvider2.SetError(TxtClave, "Obligatorio llenar esta información"); }
        //    else { e.Cancel = false; errorProvider2.SetError(TxtClave, ""); }
        //}

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e) // EQUIVALENTE A BTNCONSULTAR ES CAMBIAR DE SELECCION EN EL COMBOBOX
        {
            Consultar();
        }

        private void Consultar()
        {
            int IdEmpleado = int.Parse (cmbEmpleados.SelectedValue.ToString());
            dt = AccesoSeguridadEmpleado.Consulta_AccesoSeguridadEmpleado(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) { TxtUsuario.Text = row[0].ToString(); TxtClave.Text = row[1].ToString(); }
            }
            else { TxtUsuario.Clear(); TxtClave.Clear(); MessageBox.Show("No se ha asignado Usuario y Clave a este Empleado"); }


        }

        private void BtnEliminarAcceso_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            if (MessageBox.Show($"Está seguro de borrar el acceso y credenciales de {cmbEmpleados.Text}", "CONFIRMACION ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                AccesoSeguridadEmpleado.C_IdEmpleado = int.Parse(cmbEmpleados.SelectedValue.ToString());

                string mensaje = AccesoSeguridadEmpleado.Eliminar_AccesoSeguridadEmpleado();

                if (mensaje != "") { MessageBox.Show(mensaje); } else { MessageBox.Show("Borrado Registro"); }
                TxtClave.Clear();
                TxtUsuario.Clear();
            } 
        }
    }
}
