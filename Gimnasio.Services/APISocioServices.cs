using Gimnasio.Clases;
using Gimnasio.Clases.Dto;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gimnasio.Services
{
     public class APISocioServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();

        public List<Estado> getEstado()
        {
            return datosMaestros.GetEstado();
        }

        public List<Genero> getGenero()
        {
            return datosMaestros.GetGenero();
        }

        public List<Actividad> getActividad()
        {
            return datosMaestros.GetActividad();
        }

        
        public int insertPersona(Persona nuevaPersona)
        {
            return datosMaestros.InsertPersona(nuevaPersona);
        }

        public int insertSocioSinAbono(int idPersona)
        {
            return datosMaestros.InsertSocioSinAbono(idPersona);
        }

        public int insertSocioConAbono(int idPersona, int fk_IdAbonoSocio)
        {
            return datosMaestros.InsertSocioConAbono(idPersona, fk_IdAbonoSocio);
        }

        public int insertActividad(Actividad nuevaActividad)
        {
            return datosMaestros.InsertActividad(nuevaActividad);
        }

        public int insertAbono (Abono nuevoAbono)
        {
            return datosMaestros.InsertAbono(nuevoAbono);
        }
        

        public List<SocioAdmin> getSocios()
        {
            return datosMaestros.GetSocios();
        }

        public SocioAdmin? getSocioById(int idSocio)
        {
            return datosMaestros.GetSocioById(idSocio);
        }

        public List<ProfesorAdmin> getProfesores()
        {
            return datosMaestros.GetProfesores();
        }

        public int editarEstadoSocio(int idSocio, int idEstado)
        {
            return datosMaestros.EditarEstadoSocio(idSocio, idEstado);
        }

        public int editarActividadProfesor(int idProfesor, int fk_idActividad, double sueldo)
        {
            return datosMaestros.EditarActividadProfesor(idProfesor, fk_idActividad, sueldo);
        }

        public int actualizarFechaPagoSocio(int idSocio, DateTime fechaUltimoPago)
        {
            return datosMaestros.ActualizarFechaPagoSocio(idSocio, fechaUltimoPago);
        }

        public int editarAbonoSocio (int idSocio, int idAbonoSocio, int idEstado)
        {
            return datosMaestros.EditarAbonoSocio(idSocio, idAbonoSocio, idEstado);
        }
        
    }
}
