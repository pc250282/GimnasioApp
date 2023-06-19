
using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
    
    public class APIActvidadServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();
        public List<ActividadAdmin> getActividadesActivas()
        {
            return datosMaestros.GetActividadesActivas();
        }

        public List<Actividad> getActividad()
        {
            return datosMaestros.GetActividad();
        }

        public int insertActividad(Actividad nuevaActividad)
        {
            return datosMaestros.InsertActividad(nuevaActividad);
        }
    }
}
