using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Articulos
{
    public static class Helper
    {
        public static bool validarVacio(string entrada)
        {
            if (entrada != "")
                return true;
            else
                return false;
        }

        public static bool validarObjetoNull(Object entrada)
        {
            if (entrada != null)
                return true;
            else
                return false;
        }

        public static bool validarFiltro(ComboBox comboBox)
        {
            if(comboBox.SelectedIndex < 0)
            {
                
                MessageBox.Show("Por favor, complete todos los campos desplegables antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        public static bool soloNumeros(String cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter) && char.IsDigit(caracter))
                {
                    MessageBox.Show("Ingrese sólo números por favor");
                    return false;
                }
            }
            return true;
        }

        public static void cargarImagen(PictureBox imagen, String UrlImagen)
        {
            try
            {
                imagen.Load(UrlImagen);
            }
            catch (Exception)
            {

                imagen.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?w=740");
            }
        }
    }
}
