using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Entities
{
    public class Socio : Persona
    {
        public int numSocio { get; set; }
        public DateTime fechaInscripcion { get; set; }
        public Estado estado { get; set; }

        public override string registrarse()
        {
            return "El socio se registro";
        }

        public override string ToString()
        {
            return "Socio N°:" + this.numSocio + " Nombre:" + this.nombre + " Apellido:" + this.apellido;
        }


    }
}
