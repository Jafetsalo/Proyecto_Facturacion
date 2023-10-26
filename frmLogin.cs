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
    public partial class frmLogin : Form
    {
        string respuesta = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (validar() == true) { 
                DataTable dt = new DataTable();
                //Validar_Usuario Obj_Validar = new Validar_Usuario();
                Cls_Login accesoLogin = new Cls_Login();
                //Obj_Validar.C_StrUsuario = TxtUsuario.Text;
                accesoLogin.C_StrUsuario = TxtUsuario.Text;
                //Obj_Validar.C_StrClave = TxtPassword.Text;
                accesoLogin.C_StrClave = TxtPassword.Text;

                //Obj_Validar.ValidarUsuario();
                dt = accesoLogin.Login_ConsultarAcceso();

                if (accesoLogin.C_IdEmpleado != 0)
                {
                    MessageBox.Show("¡Bienvenido! Datos de verificiación validados" + accesoLogin.C_IdEmpleado);
                    frmPrincipal principal = new frmPrincipal();
                    this.Hide();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("CREDENCIALES NO ENCONTRADAS");
                    TxtPassword.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }


            }
           
        }

        private bool validar() 
        {
            bool errorCampos = true;
            if (TxtUsuario.Text != "" && TxtPassword.Text != string.Empty)
            {
                errorCampos = true;
            }
            else { MessageBox.Show("Debes ingresar un usuario y una contraseña"); errorCampos = false; TxtPassword.Clear(); TxtUsuario.Clear(); }
            return errorCampos;
        }

    }
}
