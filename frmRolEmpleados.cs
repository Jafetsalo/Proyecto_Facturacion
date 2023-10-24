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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRolEmpleado == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO ROL EMPLEADO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR ROL EMPLEADO";
                TxtIdRolDeEmpleados.Text = IdRolEmpleado.ToString();
                TxtNombreRol.Text = "Especialista Generalista " + IdRolEmpleado.ToString();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }


        public int IdRolEmpleado { get; set; }


    }
}
