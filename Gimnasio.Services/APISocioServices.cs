﻿using Gimnasio.Clases;
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

        public List<Abono> getAbono()
        {
            return datosMaestros.GetAbono();
        }
        public int insertPersona(Persona nuevaPersona)
        {
            return datosMaestros.InsertPersona(nuevaPersona);
        }

        public int insertSocio(int idPersona)
        {
            return datosMaestros.InsertSocio(idPersona);
        }

        public int insertActividad(Actividad nuevaActividad)
        {
            return datosMaestros.InsertActividad(nuevaActividad);
        }

        public int insertAbono (Abono nuevoAbono)
        {
            return datosMaestros.InsertAbono(nuevoAbono);
        }
        public int insertProfesor(int idPersona, Profesor profesorNuevo)
        {
            return datosMaestros.InsertProfesor(idPersona, profesorNuevo);
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

        public int editarAbonoSocio (int idSocio, SocioDto socio)
        {
            return datosMaestros.EditarAbonoSocio(idSocio, socio);
        }
        

        public List<ActividadAdmin> getActividadesActivas()
        {
            return datosMaestros.GetActividadesActivas();
        }
    }
}