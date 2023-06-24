
using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
    
    public class APIActividadServices
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

        public ActividadAdmin getActividadById(int IdActividad)
        {
            return datosMaestros.GetActividadById(IdActividad);
        }

        public int insertActividad(Actividad nuevaActividad)
        {
            return datosMaestros.InsertActividad(nuevaActividad);
        }

        public List<Abono> getAbono()
        {
            return datosMaestros.GetAbono();
        }

    }
}
