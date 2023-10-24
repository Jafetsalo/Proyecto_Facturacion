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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Datos Actualizados");
        }


        public int IdProducto { get; set; }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if (IdProducto == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR PRODUCTO";
                TxtIdProducto.Text = IdProducto.ToString();
                TxtNombreProducto.Text = "Artículo 1 Elemento";
                TxtCodigoReferencia.Text = "123456789";
                TxtCategoriaProducto.Text = "Articulos generales";
                TxtCantidadStock.Text = "9874";
                TxtRutaImagen.Text = "abc@ejemplo.com";
            }

        }
    }
}
