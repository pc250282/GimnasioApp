using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public  class Persona
    {
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public int fk_IdGenero { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public int fk_IdSocio { get; set; }

          
    }
}
