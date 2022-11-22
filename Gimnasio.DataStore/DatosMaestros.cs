using DataStore;
using Gimnasio.Clases;
using System;

namespace Gimnasio.DataStore
{
    public class DatosMaestros
    {
        DBOperation dbOperation = new DBOperation();


        public List<SocioAdmin> GetSocios()
        {
            List<SocioAdmin> LstSocios = new List<SocioAdmin>();
            string sql = "SELECT S.IdSocio,S.fechaDeInscripcion,S.fechaUltimoPago,"
                        + "P.dni,P.nombre,P.apellido,P.telefono,"
                        + "E.nombreEstado "
                        + "FROM Socio S "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN Estado E ON S.fk_IdEstado = E.IdEstado";
            LstSocios = dbOperation.OperationQuery<SocioAdmin>(sql);
            return LstSocios;
        }

        public List<ProfesorAdmin> GetProfesores()
        {
            List<ProfesorAdmin> LstProfesores = new List<ProfesorAdmin>();
            string sql = "SELECT PR.idProfesor,PR.fechaContratacion,PR.sueldo,"
                        + "P.nombre,P.apellido,"
                        + "E.nombreEstado, "
                        + "A.nombreActividad, "
                        + "AB.valorCuotaPura,porcentajeProfesor "
                        + "FROM Profesor PR "
                        + "INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona "
                        + "INNER JOIN Estado E ON PR.fk_IdEstado = E.IdEstado "
                        + "INNER JOIN Actividad A ON PR.fk_idActividad = A.idActividad "
                        + "INNER JOIN Abono AB on A.fk_idAbono= AB.idAbono";
            LstProfesores = dbOperation.OperationQuery<ProfesorAdmin>(sql);
            return LstProfesores;
        }

       


        public List<Genero> GetGenero()
        {
            List<Genero> LstGenero = new List<Genero>();
            string sql = "SELECT IdGenero, nombreGenero FROM Genero";
            LstGenero = dbOperation.OperationQuery<Genero>(sql);
            return LstGenero;
        }

        public List<Estado> GetEstado()
        {
            List<Estado> LstEstado = new List<Estado>();
            string sql = "SELECT idEstado, nombreEstado FROM Estado";
            LstEstado = dbOperation.OperationQuery<Estado>(sql);
            return LstEstado;
        }

        public List<Abono> GetAbono()
        {
            List<Abono> LstAbono = new List<Abono>();
            string sql = "SELECT idAbono,nombreAbono FROM Abono";
            LstAbono = dbOperation.OperationQuery<Abono>(sql);
            return LstAbono;
        }
        public List<Actividad> GetActividad()
        {
            List<Actividad> LstActividad = new List<Actividad>();
            string sql = "SELECT IdActividad, nombreActividad,horario FROM Actividad";
            LstActividad = dbOperation.OperationQuery<Actividad>(sql);
            return LstActividad;
        }

        public int InsertPersona(Persona nuevaPersona)
        {
            string sql = "INSERT INTO Persona (nombre,apellido,dni,telefono,direccion,fk_IdGenero,fechaNacimiento)" +
                "OUTPUT INSERTED.idPersona " +
                "VALUES(@nombre,@apellido,@dni,@telefono,@direccion,@fk_IdGenero,@fechaNacimiento) ";

            object paramList = new
            {
                nombre= nuevaPersona.nombre,
                apellido = nuevaPersona.apellido,
                dni = nuevaPersona.dni,
                telefono = nuevaPersona.telefono,
                direccion = nuevaPersona.direccion,
                fk_IdGenero = nuevaPersona.fk_IdGenero,
                fechaNacimiento = nuevaPersona.fechaNacimiento,
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public int InsertActividad(Actividad nuevaActividad)
        {
            string sql = "INSERT INTO Actividad (nombreActividad,horario,cupo,fk_idAbono)" +
                "OUTPUT INSERTED.idActividad " +
                "VALUES(@nombreActividad,@horario,@cupo,@fk_idAbono) ";

            object paramList = new
            {
                nombreActividad = nuevaActividad.nombreActividad,
                horario = nuevaActividad.horario,
                cupo = nuevaActividad.cupo,
                fk_idAbono = nuevaActividad.fk_idAbono
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public int InsertSocio(int idPersona)
        {

            string sql = "INSERT INTO Socio (fk_idPersona, fechaDeInscripcion,fechaUltimoPago, fk_IdEstado)  Values" +
                "(@fk_idPersona, @fechaDeInscripcion, @fechaUltimoPago,@fk_IdEstado)";

            Object paramList = new
            {
                fk_idPersona = idPersona,
                fechaDeInscripcion = DateTime.Now,
                fechaUltimoPago= DateTime.Now,
                fk_IdEstado = 1
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;

        }

        public int InsertProfesor(int idPersona, Profesor profesorNuevo)
        {

            string sql = "INSERT INTO Profesor (fk_idPersona,fk_idEstado,fk_idActividad,fechaContratacion,sueldo)  Values" +
                "(@fk_idPersona, @fk_idActividad, @sueldo, @fechaContratacion, @fk_idEstado)";

            Object paramList = new
            {
                fk_idPersona = idPersona,
                fk_idActividad = profesorNuevo.fk_idActividad,
                sueldo = profesorNuevo.sueldo,
                fechaContratacion = profesorNuevo.fechaContratacion,
                fk_idEstado = 1
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;

        }

        public int EditarEstadoSocio(int idSocio, int idEstado)
        {
            string sql = "UPDATE Socio SET fk_IdEstado = @idEstado WHERE idSocio = @idSocio";
            Object paramList = new { idSocio = idSocio, idEstado = idEstado };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }

        public int EditarActividadProfesor(int idProfesor, int fk_idActividad, double sueldo)
        {
            string sql = "UPDATE Profesor SET fk_idActividad = @fk_idActividad, sueldo=@sueldo WHERE idProfesor = @idProfesor";
            Object paramList = new {idProfesor=idProfesor, fk_idActividad=fk_idActividad, sueldo=sueldo };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);
            return affectedRows;
        }
        public int ActualizarFechaPagoSocio(int idSocio, DateTime fechaUltimoPago)
        {
            string sql = "UPDATE Socio SET fk_IdEstado = 1, fechaUltimoPago=@fechaUltimoPago WHERE idSocio = @idSocio";
            Object paramList = new { idSocio = idSocio, fechaUltimoPago=fechaUltimoPago };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;

        }
    }
}


