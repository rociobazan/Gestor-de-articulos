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
using Dominio;
using Gestion_de_Articulos;

namespace Gestion_de_Articulos
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        public void cargarImagen(String imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?w=740");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo ventana = new frmAltaArticulo();
            ventana.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            ocultarColumnas();
            cargarImagen(listaArticulo[0].ImagenUrl);
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Precio");
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns ["ImagenUrl"].Visible = false;
            dgvArticulos.Columns ["Id"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estás seguro que quieres eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalles ventanaDetalles = new frmDetalles(seleccionado);
            ventanaDetalles.ShowDialog();
        }
        

        private void tbxFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            String filtro = tbxFiltrar.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio") 
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Termina con");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tbxFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboCampo.Items.Clear();
            cboCriterio.Items.Clear();
            tbxFiltroAvanzado.Clear();
            cargar();
        }

        private void btnMarcasCategorias_Click(object sender, EventArgs e)
        {
            frmMarcasCategorias frmMarcasCategorias = new frmMarcasCategorias();
            frmMarcasCategorias.ShowDialog();
        }
    }
      
}
