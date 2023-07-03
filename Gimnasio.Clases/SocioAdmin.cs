using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class SocioAdmin
    {
        public int IdSocio { get; set; }
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string nombreGenero { get; set; }
        public DateTime fechaDeInscripcion { get; set; }
        public string mail { get; set; }    
        public string nombreEstado { get; set; }
        public DateTime fechaUltimoPago { get; set; }
        public string? nombreAbono { get; set; }
        public int fk_IdAbonoSocio { get; set; }
        public int fk_IdEstado { get; set; }
        public DateTime fechaNacimiento { get; set; }
        



    }
}
