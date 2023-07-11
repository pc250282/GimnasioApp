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
        public int horasPorSemana { get; set; }
        public double valorCuotaPura { get; set; }
        public string nombreAbono { get; set; }
        public double porcentajeEstablecimiento { get; set; }
        public double porcentajeProfesor { get; set; }
        public int cupoUtilizado { get; set; }
        public int cupoDisponible { get; set; }
        public int fk_Profesor_id { get;set; }
    }
}
