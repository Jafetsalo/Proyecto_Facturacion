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
    public partial class frmCategoriaProducto : Form
    {
        public frmCategoriaProducto()
        {
            InitializeComponent();
        }

        private void frmCategoriaProducto_Load(object sender, EventArgs e)
        {
            if (IdCategoriaProducto == 0)
            {
                LblTitulo.Text = "INGRESO NUEVA CATEGORIA PRODUCTO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR PRODUCTO";
                TxtIdProducto.Text = IdCategoriaProducto.ToString();
                TxtNombreCategoriaProducto.Text = "Categoria Artículo 1 Elemento";

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


        public int IdCategoriaProducto { get; set; }


    }
}
