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
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void fmAcercaDe_Load(object sender, EventArgs e)
        {
            TxtAcercaDe.Text = "VERSION 1.0.1 \nEste aplicativo de escritorio, desarrollado siguiendo " +
                "estándares de nomenclatura y diseño gráfico moderno, se centra en la creación y gestión de formularios " +
                "para entornos de escritorio. El proyecto \"Pantallas_Sistema_facturación\" servirá como plantilla para futuras " +
                "prácticas del curso.\r\n\r\nRequisitos: Visual Studio 2019 o superior y acceso a Internet.\r\n\r\nEl aplicativo incluye:\r\n\r\nFormulario de " +
                "inicio de sesión.\r\nFormulario principal con opciones de menú.\r\nFormularios de administración de clientes (Listar y actualizar).\r\nFormularios " +
                "para productos, categorías de productos, facturas, informes, empleados y roles de empleados.\r\nFormulario de administración " +
                "de seguridad.\r\nLos formularios cumplen con estándares de programación y se utiliza el componente \"ErrorProvider\" para validar " +
                "campos al presionar \"Actualizar,\" asegurando que los campos principales no estén vacíos.\r\n\r\nAdemás, se incluye una " +
                "sección de ayuda, utilizando el componente \"WebBrowser\" para mostrar una página web, como la oficial de Microsoft, y " +
                "una sección \"Acerca de\" que presenta información mediante etiquetas, botones y cuadros de texto en un panel.\r\n\r\n" +
                "Este aplicativo proporciona una base sólida para el desarrollo de sistemas de facturación y gestión en entornos de escritorio " +
                "con un enfoque en la usabilidad y el diseño gráfico moderno.";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
