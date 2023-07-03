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

        public int editarEstadoProfesor(int idProfesor)
        {
            return datosMaestros.EditarEstadoProfesor(idProfesor);
        }

        public int asignarSueldoProfesor(int idProfesor, double sueldo)
        {
            return datosMaestros.AsignarSueldoProfesor(idProfesor, sueldo);
        }

        public ProfesorAdmin getProfesorById(int idProfesor)
        {
            return datosMaestros.GetProfesorById(idProfesor) ;
        }

        public List<ActividadAdmin> getActividesDelProfesor(int fk_Profesor_id)
        {
            return datosMaestros.GetActividadesDelProfesor(fk_Profesor_id);
        }
    }
}
