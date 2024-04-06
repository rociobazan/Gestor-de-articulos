using negocio;
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
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             Articulo nuevoArticulo = new Articulo();
             ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {   nuevoArticulo.Codigo = tbxCodigo.Text;
                nuevoArticulo.Nombre = tbxNombre.Text;
                nuevoArticulo.Descripcion = tbxDescripcion.Text;
                nuevoArticulo.Marca = (Marca)cboMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                nuevoArticulo.ImagenUrl = tbxImagenUrl.Text;
                nuevoArticulo.Precio = Decimal.Parse(tbxPrecio.Text);

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
