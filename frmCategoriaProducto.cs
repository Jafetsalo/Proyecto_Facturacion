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
    public partial class frmCategoriaProducto : Form
    {
        DataTable dt = new DataTable();
        Cls_CategoriaProducto categoriaProducto = new Cls_CategoriaProducto();
        public int IdCategoriaProducto { get; set; }
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
                LblTitulo.Text = "MODIFICAR CATEGORIA PRODUCTO";
                llenarCampos();

            }
        }

        private void llenarCampos()
        {
            dt = categoriaProducto.Consultar_CategoriaProducto(IdCategoriaProducto);
            if (dt.Rows.Count > 0) 
            {
                foreach ( DataRow row in dt.Rows) 
                {
                    TxtIdProducto.Text = row[0].ToString();
                    TxtNombreCategoriaProducto.Text = row[1].ToString();
                }

            }
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
            DialogResult respuesta = MessageBox.Show("Seguro Desea Salir de la Edición de Categoria Producto", "PREGUNTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK) { this.Close(); }

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
                categoriaProducto.C_IdCategoria = IdCategoriaProducto;
                categoriaProducto.C_StrDescripcion = TxtNombreCategoriaProducto.Text;
                categoriaProducto.C_StrUsuarioModifico = "Administrador";
                mensaje = categoriaProducto.Actualizar_CategoriaProducto();
                MessageBox.Show(mensaje);
            }
            
        }

        private bool validarFormulario()
        {
            bool errorCampos = true;

            if (TxtNombreCategoriaProducto.Text == string.Empty) { MensajeError.SetError(TxtNombreCategoriaProducto, "Atención: Ingresar Nombre Categoria"); TxtNombreCategoriaProducto.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtNombreCategoriaProducto, ""); }

            return errorCampos;
        }
    }
}
