using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
    
    public class APIProfesorServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();
        public List<ProfesorAdmin> getProfesores()
        {
            return datosMaestros.GetProfesores();
        }

        public int insertProfesor(int idPersona, Profesor profesorNuevo)
        {
            return datosMaestros.InsertProfesor(idPersona, profesorNuevo);
        }

    }
}
