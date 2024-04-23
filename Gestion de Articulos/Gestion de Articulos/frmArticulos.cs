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
            Text = "Gestor de Artículos";
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Helper.cargarImagen(pbxArticulo, seleccionado.ImagenUrl);
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
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                Helper.cargarImagen(pbxArticulo, listaArticulo[0].ImagenUrl);
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Codigo");
                cboCampo.Items.Add("Precio");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns ["ImagenUrl"].Visible = false;
            dgvArticulos.Columns ["Id"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if (Helper.validarObjetoNull(dgvArticulos.CurrentRow))
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione un artículo a modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (!Helper.validarObjetoNull(dgvArticulos.CurrentRow)) 
                {
                    MessageBox.Show("Por favor, seleccione un artículo");
                    return;
                }
                    

                DialogResult respuesta = MessageBox.Show("Estás seguro que quieres eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.validarObjetoNull(dgvArticulos.CurrentRow))
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmDetalles ventanaDetalles = new frmDetalles(seleccionado);
                    ventanaDetalles.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un artículo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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
                if (Helper.validarFiltro(cboCampo) || Helper.validarFiltro(cboCriterio))
                {
                    return;
                }

                if(cboCampo.SelectedItem.ToString() == "Precio")
                {
                    if(!Helper.validarVacio(tbxFiltroAvanzado.Text))
                    {
                        MessageBox.Show("Debes cargar el filtro para realizar la búsqueda");
                        return; 
                    }
                    if (!Helper.soloNumeros(tbxFiltroAvanzado.Text))
                    {
                        return;
                    }
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tbxFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void btnEliminarMarcasCategorias_Click(object sender, EventArgs e)
        {
            frmEliminarMarcaCategoria eliminar = new frmEliminarMarcaCategoria();
            eliminar.ShowDialog();
        }
    }
      
}
