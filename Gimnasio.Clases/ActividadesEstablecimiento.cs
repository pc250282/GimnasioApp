using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class ActividadesEstablecimiento
    {
        public int idActividadEstablecimiento { get; set; }
        public Actividad fk_idActividad { get; set; }
        public Abono fk_idAbono { get; set; }
        public Profesor fk_idProfesor { get; set; }

    }
}
