using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace Gestion_de_Articulos
{
    public partial class frmMarcasCategorias : Form
    {
        public frmMarcasCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                marca.Descripcion = tbxMarca.Text;
                categoria.Descripcion = tbxCategoria.Text;

                categoriaNegocio.agregar(categoria);
                marcaNegocio.agregar(marca);

                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
