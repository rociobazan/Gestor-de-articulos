using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Gestion_de_Articulos
{
    public partial class frmDetalles : Form
    {
        Articulo articulo;
        public frmDetalles()
        {
            InitializeComponent();
        }
        public frmDetalles(Articulo seleccionado)
        {
            InitializeComponent();
            this.articulo = seleccionado;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            
            try
            {
                lblInsertNombre.Text = articulo.Nombre;
                lblInsertCodigo.Text = articulo.Codigo;
                lblInsertDescripcion.Text = articulo.Descripcion;
                lblInsertMarca.Text = articulo.Marca.ToString();
                lblInsertCategoria.Text = articulo.Categoria.ToString();
                lblInsertPrecio.Text = articulo.Precio.ToString();
                cargarImagen(articulo.ImagenUrl);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargarImagen(String imagen)
        {
            try
            {
                pbxDetalles.Load(imagen);
            }
            catch
            {
                pbxDetalles.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?w=740");
            }
        }
    }

}
