using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.GUI.Validaciones
{
    class ValidacionesFront
    {
        public void soloLetras( KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    //se escribe
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    // se puede borrar
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    // se escribe un espacio
                    e.Handled = false;
                }
                else
                {
                    //No se escribe 
                    e.Handled = true;
                }
            }
            catch (Exception error)
            {
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    //se escribe
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    // se puede borrar
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    // se escribe un espacio
                    e.Handled = false;
                }
                else
                {
                    //No se escribe 
                    e.Handled = true;
                }
            }
            catch (Exception error)
            {
            }
        }
    }
}
