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
            Text = "Ver detalles";
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
                Helper.cargarImagen(pbxDetalles, articulo.ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }

}
