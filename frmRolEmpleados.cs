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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Roles rol = new Cls_Roles();
        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRolEmpleado == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO ROL EMPLEADO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR ROL EMPLEADO";
                llenarCampos();

            }
        }

        private void llenarCampos() 
        {
            TxtIdRolDeEmpleados.Text = IdRolEmpleado.ToString();
            dt = rol.ConsultarRoles(IdRolEmpleado);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TxtIdRolDeEmpleados.Text = row[0].ToString();
                    TxtNombreRol.Text = row[1].ToString();
                    
                }
            }
            //TxtNombreRol.Text = 
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                rol.C_IdRolEmpleado = IdRolEmpleado;
                rol.C_StrDescripcion = TxtNombreRol.Text;

                mensaje = rol.Actualizar_RolEmpleado();
                MessageBox.Show(mensaje);
            }
        }

        private bool validarFormulario()
        {
            bool errorCampos = true;
            return errorCampos;
        }

        public int IdRolEmpleado { get; set; }

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
