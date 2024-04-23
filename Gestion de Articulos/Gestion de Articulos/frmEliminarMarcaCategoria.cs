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
using System.Drawing.Text;


namespace Gestion_de_Articulos
{
    public partial class frmEliminarMarcaCategoria : Form
    {
        public frmEliminarMarcaCategoria()
        {
            InitializeComponent();
            Text = "Eliminar Marcas/Categorías";
        }

        private void frmEliminarMarcaCategoria_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarcas.DataSource = marcaNegocio.listar();
                cboMarcas.SelectedIndex = -1;
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca marcaEliminar = (Marca)cboMarcas.SelectedItem;
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria categoriaEliminar =(Categoria)cboCategoria.SelectedItem;
            try
            {
                if (Helper.validarObjetoNull(marcaEliminar) || Helper.validarObjetoNull(categoriaEliminar))
                {
                    DialogResult respuesta = MessageBox.Show("Estás seguro que quieres eliminar?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)

                        if (Helper.validarObjetoNull(marcaEliminar))
                            marcaNegocio.eliminar(marcaEliminar);


                    if (Helper.validarObjetoNull(categoriaEliminar))
                        categoriaNegocio.eliminar(categoriaEliminar);

                    MessageBox.Show("Eliminado correctamente");
                    Close();
                }
                else
                    MessageBox.Show("Seleccione algún campo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
