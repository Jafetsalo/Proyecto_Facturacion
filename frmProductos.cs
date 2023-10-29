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
    public partial class frmProductos : Form
    {
        Cls_Producto producto = new Cls_Producto();
        DataTable dt = new DataTable();
        public int IdProducto { get; set; }
        public frmProductos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro Desea Salir de la Edición de Producto", "PREGUNTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
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
                producto.C_IdProducto = IdProducto;
                producto.C_StrNombre = TxtNombreProducto.Text;
                producto.C_StrCodigo = TxtCodigoReferencia.Text;
                producto.C_NumPrecioCompra = float.Parse(TxtPrecioCompra.Text);
                producto.C_NumPrecioVenta = float.Parse(TxtPrecioVenta.Text);
                producto.C_IdCategoria = int.Parse(cmbCategoriaProducto.SelectedValue.ToString());
                producto.C_StrDetalle = TxtDetalleProducto.Text;
                producto.C_StrFoto = TxtRutaImagen.Text;
                producto.C_NumStock = int.Parse(TxtCantidadStock.Text);
                producto.C_StrUsuarioModifica = "Adminstrador";
                mensaje = producto.ActualizarProducto();
                MessageBox.Show(mensaje);
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
        private bool validarFormulario()
        {
            bool errorCampos = true;

            if (TxtNombreProducto.Text == string.Empty)
            { MensajeError.SetError(TxtNombreProducto, "Atención: Ingresar Nombre Producto"); TxtNombreProducto.Focus(); errorCampos = false; }
            else { MensajeError.SetError(TxtNombreProducto, ""); }

            //if (!esNumerico(TxtIdProducto.Text))
            //{ MensajeError.SetError(TxtIdProducto, "Atención: Solo Números En Campo ID Producto"); TxtIdProducto.Focus(); errorCampos = false; }
            //else { MensajeError.SetError(TxtIdProducto, ""); }

            return errorCampos;


        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (IdProducto == 0)
            {
                LblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                LblTitulo.Text = "MODIFICAR PRODUCTO";
                llenarCampos();
                
            }

        }

        private void llenarCombo()
        {
            cmbCategoriaProducto.DataSource = producto.ConsultarCategoria();
            cmbCategoriaProducto.DisplayMember = "StrDescripcion";
            cmbCategoriaProducto.ValueMember = "IdCategoria";
        }

        private void llenarCampos()
        {
            dt = producto.ConsultarProducto(IdProducto);
            if (dt != null) 
            {
                foreach (DataRow row in dt.Rows) 
                {
                    TxtIdProducto.Text = row[0].ToString();
                    TxtNombreProducto.Text = row[1].ToString();
                    TxtCodigoReferencia.Text = row[2].ToString();
                    TxtPrecioCompra.Text = row[3].ToString();
                    TxtPrecioVenta.Text = row[4].ToString();
                    TxtCantidadStock.Text = row[8].ToString();
                    TxtRutaImagen.Text = row[7].ToString();
                    TxtDetalleProducto.Text = row[6].ToString();
                    cmbCategoriaProducto.SelectedValue = row[5].ToString();
                }
            }
            //TxtIdProducto.Text = IdProducto.ToString();
            //TxtNombreProducto.Text = "Artículo 1 Elemento";
            //TxtCodigoReferencia.Text = "123456789";
            //TxtCategoriaProducto.Text = "Articulos generales";
            
            //TxtCantidadStock.Text = "9874";
            //TxtRutaImagen.Text = "abc@ejemplo.com";
        }



        
    }
}
