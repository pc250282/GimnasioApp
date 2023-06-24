using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class ActividadAdmin
    {
        public int IdActividad { get; set; }
        public string nombreActividad { get; set; }
        public string nombre { get; set; }
        public string horario { get; set; }
        public double valorCuotaPura { get; set; }
        public int cupo { get; set; }
        public string nombreAbono { get; set; }
    }
}
