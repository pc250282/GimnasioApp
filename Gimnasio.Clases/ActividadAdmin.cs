using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class ActividadAdmin
    {
        public int idActividadesAdmin { get; set; }
        public string nombreActividad { get; set; }
        public string nombreProfesor { get; set; }
        public double valorActividad { get; set; }
        public int cupoDisponible { get; set; }
        public int cupoTotal { get; set; }
    }
}
