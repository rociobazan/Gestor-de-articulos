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
using System.IO;
using static System.Collections.Specialized.BitVector32;
using System.Configuration;

namespace Gestion_de_Articulos
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog imagen = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Id";
                cboMarca.SelectedIndex = -1;

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "Id";
                cboCategoria.SelectedIndex = -1;


                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    tbxPrecio.Text = articulo.Precio.ToString();
                    Helper.cargarImagen(pbxNuevoArt, articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFormulario())
                    return;
                if(articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = tbxImagenUrl.Text;
                if (!Helper.numerosDecimales(tbxPrecio.Text))
                    return;
                articulo.Precio = Decimal.Parse(tbxPrecio.Text);
                
                if(imagen != null && !(tbxImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(imagen.FileName, ConfigurationManager.AppSettings["img"] + imagen.SafeFileName);
                }

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void tbxImagenUrl_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(pbxNuevoArt, tbxImagenUrl.Text);
        }

        private bool validarFormulario()
        {
           if(!Helper.validarVacio(tbxNombre.Text) || !Helper.validarVacio(tbxCodigo.Text) || !Helper.validarVacio(tbxDescripcion.Text) || !Helper.validarVacio(tbxPrecio.Text) || !Helper.validarObjetoNull(cboMarca.SelectedItem) || !Helper.validarObjetoNull(cboCategoria.SelectedItem))
           {
                MessageBox.Show("Por favor, complete todos los campos");
                return true;
           }
           return false;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg;|png|*.png";

            if (imagen.ShowDialog() == DialogResult.OK)
            {
                tbxImagenUrl.Text = imagen.FileName;
                Helper.cargarImagen(pbxNuevoArt, imagen.FileName);

            }
        }
    }
}
