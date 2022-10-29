using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Profesor : Persona
    {
        public int numLegajo { get; set; }
        public string actividad { get; set; }
        public Estado estadoProfesor { get; set; }
        public double sueldo { get; set; }

        public override void registroGimnasio()
        {
            Console.WriteLine("El profesor empezo a trabajar en un gimnasio");
        }
    }
}
