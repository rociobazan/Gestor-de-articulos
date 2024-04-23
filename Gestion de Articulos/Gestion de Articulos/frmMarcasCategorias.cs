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
            Text = "Agregar Marcas/Categorías";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marcaNueva = new Marca();
            Categoria categoriaNueva = new Categoria();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            
            try
            {
                marcaNueva.Descripcion = tbxMarca.Text;
                categoriaNueva.Descripcion = tbxCategoria.Text;
                List<Marca> listaMarcas = marcaNegocio.listar();
                List<Categoria> listaCategorias = categoriaNegocio.listar();
                

                if (Helper.validarVacio(marcaNueva.Descripcion)) 
                {
                    bool estaRepetido = listaMarcas.Any(Marca => Marca.Descripcion == categoriaNueva.Descripcion);
                    if (!estaRepetido)
                    {
                        marcaNegocio.agregar(marcaNueva);
                        MessageBox.Show("Marca agregada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("La marca que intenta ingresar ya existe");
                        return;
                    }
                }
                    
                if (Helper.validarVacio(categoriaNueva.Descripcion))
                {
                    bool estaRepetido = listaCategorias.Any(Categoria => Categoria.Descripcion == categoriaNueva.Descripcion);
                    if (!estaRepetido)
                    {
                        categoriaNegocio.agregar(categoriaNueva);
                        MessageBox.Show("Categoria agregada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("La categoría que intenta ingresar ya existe");
                        return;
                    }
                }

                if(!Helper.validarVacio(marcaNueva.Descripcion) && !Helper.validarVacio(categoriaNueva.Descripcion))
                {
                    MessageBox.Show("Por favor, ingrese un dato");
                    return;
                }
                  
                Close();
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
