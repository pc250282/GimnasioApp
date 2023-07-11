using Gimnasio.Clases;
using Gimnasio.Clases.Dto;
using System;

namespace Gimnasio.DataStore
{
    public class DatosMaestros
    {
        DBOperation dbOperation = new DBOperation();


        public List<SocioAdmin> GetSocios()
        {
            List<SocioAdmin> LstSocios = new List<SocioAdmin>();
            string sql = "SELECT S.IdSocio,S.fechaDeInscripcion,S.fechaUltimoPago,S.fk_IdAbonoSocio, "
                        + "P.idPersona,P.dni,P.nombre,P.apellido,P.telefono,P.direccion,P.mail,P.fechaNacimiento, "
                        + "E.nombreEstado,"
                        + "G.nombreGenero, "
                        + "ASO.nombreAbono "
                        + "FROM Socio S "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN Estado E ON S.fk_IdEstado = E.IdEstado "
                        + "INNER JOIN Genero G ON P.fk_IdGenero = G.IdGenero "
                        + "LEFT JOIN AbonoSocio ASO ON S.fk_IdAbonoSocio = ASO.IdAbonoSocio";
            LstSocios = dbOperation.OperationQuery<SocioAdmin>(sql);
            return LstSocios;
        }

        public SocioAdmin? GetSocioById(int idSocio)
        {
            SocioAdmin socio;
            string sql = "SELECT S.IdSocio,S.fechaDeInscripcion,S.fechaUltimoPago,S.fk_IdAbonoSocio,fk_IdEstado, "
                        + "P.idPersona,P.dni,P.nombre,P.apellido,P.telefono,P.direccion,P.mail,P.fechaNacimiento, "
                        + "E.nombreEstado,"
                        + "G.nombreGenero,"
                        + "ASO.nombreAbono,valor "
                        + "FROM Socio S "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN Estado E ON S.fk_IdEstado = E.IdEstado "
                        + "INNER JOIN Genero G ON P.fk_IdGenero = G.IdGenero "
                        + "LEFT JOIN AbonoSocio ASO ON S.fk_IdAbonoSocio = ASO.IdAbonoSocio "
                        + "WHERE S.IdSocio = @IdSocio";
            socio = dbOperation.OperationQueryById2<SocioAdmin>(sql, new {IdSocio = idSocio});
            return socio;
        }
        


        public List<ProfesorAdmin> GetProfesores()
        {
            List<ProfesorAdmin> LstProfesores = new List<ProfesorAdmin>();
            string sql = "SELECT PR.idProfesor,PR.fechaContratacion,PR.sueldo,"
                        + "P.nombre,P.apellido,mail,"
                        + "E.nombreEstado "
                        + "FROM Profesor PR "
                        + "INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona "
                        + "LEFT JOIN Estado E ON PR.fk_IdEstado = E.IdEstado";
            LstProfesores = dbOperation.OperationQuery<ProfesorAdmin>(sql);
            return LstProfesores;
        }

        public List<ActividadAdmin> GetActividadesActivas()
        {
            List<ActividadAdmin> LstActividades = new List<ActividadAdmin>();
            string sql = "SELECT ACT.IdActividad,ACT.nombreActividad,ACT.horario,ACT.horasPorSemana,ACT.fk_Profesor_id,ACT.fk_Abono_id,ACT.cupoDisponible,ACT.cupoUtilizado,"
                        + "AB.valorCuotaPura,AB.nombreAbono,"
                        + "P.nombre "
                        + "FROM Actividad ACT "
                        + "LEFT JOIN Abono AB ON ACT.fk_Abono_id = AB.idAbono "
                        + "LEFT JOIN Profesor PR ON ACT.fk_Profesor_id = PR.IdProfesor "
                        + "LEFT JOIN Persona P ON PR.fk_idPersona = P.idPersona";
            LstActividades = dbOperation.OperationQuery<ActividadAdmin>(sql);
            return LstActividades;
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
            string sql = "SELECT idAbono,nombreAbono,valorCuotaPura FROM Abono";
            LstAbono = dbOperation.OperationQuery<Abono>(sql);
            return LstAbono;
        }

        public List<AbonoSocio> GetAbonoSocios()
        {
            List<AbonoSocio> LstAbonoSocio = new List<AbonoSocio>();
            string sql = "SELECT idAbonoSocio,nombreAbono,valor FROM AbonoSocio";
            LstAbonoSocio = dbOperation.OperationQuery<AbonoSocio>(sql);
            return LstAbonoSocio;
        }
        public List<Actividad> GetActividad()
        {
            List<Actividad> LstActividad = new List<Actividad>();
            string sql = "SELECT IdActividad, nombreActividad,horario FROM Actividad";
            LstActividad = dbOperation.OperationQuery<Actividad>(sql);
            return LstActividad;
        }

        public List<Actividad> GetActividades()
        {
            List<Actividad> LstActividades = new List<Actividad>();
            string sql = "SELECT ACT.idActividad, ACT.nombreActividad,ACT.horaPorSemana,ACT.horario,ACT.cupoDisponible,"
                        + "AB.valorCuotaPura,AB.nombreAbono, "
                        + "P.nombre, "
                        + "PR.fk_idActividad "
                        + "FROM Actividad ACT "
                        + "INNER JOIN Abono AB ON ACT.fk_Abono_id = AB.idAbono ";
            LstActividades = dbOperation.OperationQuery<Actividad>(sql);
            return LstActividades;
        }

        public int InsertPersona(Persona nuevaPersona)
        {
            string sql = "INSERT INTO Persona (nombre,apellido,dni,telefono,direccion,fk_IdGenero,fechaNacimiento,mail)" +
                "OUTPUT INSERTED.idPersona " +
                "VALUES(@nombre,@apellido,@dni,@telefono,@direccion,@fk_IdGenero,@fechaNacimiento,@mail) ";

            object paramList = new
            {
                nombre= nuevaPersona.nombre,
                apellido = nuevaPersona.apellido,
                dni = nuevaPersona.dni,
                telefono = nuevaPersona.telefono,
                direccion = nuevaPersona.direccion,
                fk_IdGenero = nuevaPersona.fk_IdGenero,
                fechaNacimiento = nuevaPersona.fechaNacimiento,
                mail=nuevaPersona.mail,
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public int InsertActividad(Actividad nuevaActividad)
        {
            string sql = "INSERT INTO Actividad (nombreActividad,horario,horasPorSemana,fk_Abono_id,fk_Profesor_id,cupoDisponible)" +
                "OUTPUT INSERTED.idActividad " +
                "VALUES(@nombreActividad,@horario,@horasPorSemana,@fk_Abono_id,@fk_Profesor_id,@cupoDisponible) ";

            object paramList = new
            {
                nombreActividad = nuevaActividad.nombreActividad,
                horario = nuevaActividad.horario,
                horasPorSemana = nuevaActividad.horasPorSemana,
                fk_Abono_id = nuevaActividad.fk_Abono_id,
                fk_Profesor_id=nuevaActividad.fk_Profesor_id,
                cupoDisponible=nuevaActividad.cupoDisponible
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public int InsertSocioSinAbono(int idPersona)
        {

            string sql = "INSERT INTO Socio (fk_idPersona, fechaDeInscripcion, fk_IdEstado)  Values" +
                "(@fk_idPersona, @fechaDeInscripcion, @fk_IdEstado)";

            Object paramList = new
            {
                fk_idPersona = idPersona,
                fechaDeInscripcion = DateTime.Now,
                fk_IdEstado = 1007
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;

        }

        public int InsertSocioConAbono(int idPersona, int fk_IdAbonoSocio)
        {

            string sql = "INSERT INTO Socio (fk_idPersona, fechaDeInscripcion, fk_IdEstado, fk_IdAbonoSocio)  Values" +
                "(@fk_idPersona, @fechaDeInscripcion,@fk_IdEstado,@fk_IdAbonoSocio)";

            Object paramList = new
            {
                fk_idPersona = idPersona,
                fechaDeInscripcion = DateTime.Now,
                fk_IdEstado = 1007,
                fk_IdAbonoSocio = fk_IdAbonoSocio
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;

        }

        public int InsertProfesor(int idPersona, Profesor profesorNuevo)
        {

            string sql = "INSERT INTO Profesor (fk_idPersona,fk_idEstado,fechaContratacion,sueldo)  Values" +
                "(@fk_idPersona, @sueldo, @fechaContratacion, @fk_idEstado)";

            Object paramList = new
            {
                fk_idPersona = idPersona,
                sueldo = profesorNuevo.sueldo,
                fechaContratacion = profesorNuevo.fechaContratacion,
                fk_idEstado = 1
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;

        }

        
        public int InsertAbono(Abono nuevoAbono) { 
            string sql = "INSERT INTO Abono (nombreAbono,valorCuotaPura,porcentajeEstablecimiento,porcentajeProfesor)" +
                "OUTPUT INSERTED.idAbono " +
                "VALUES(@nombreAbono,@valorCuotaPura,@porcentajeEstablecimiento,@porcentajeProfesor) ";

            object paramList = new
            {
                nombreAbono = nuevoAbono.nombreAbono,
                valorCuotaPura = nuevoAbono.valorCuotaPura,
                porcentajeEstablecimiento = nuevoAbono.porcentajeEstablecimiento,
                porcentajeProfesor = nuevoAbono.porcentajeProfesor
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public int EditarEstadoSocio(int idSocio, int idEstado)
        {
            string sql = "UPDATE Socio SET fk_IdEstado = @idEstado WHERE idSocio = @idSocio";
            Object paramList = new { idSocio = idSocio, idEstado = idEstado };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }

        public int AsignarSueldoProfesor(int idProfesor, double sueldo)
        {
            string sql = "UPDATE Profesor SET sueldo = @sueldo, fk_idEstado=@fk_idEstado WHERE idProfesor = @idProfesor";
            Object paramList = new {
                idProfesor=idProfesor, 
                sueldo=sueldo,
                fk_idEstado=1};
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

        public int EditarAbonoSocio(int idSocio, int idAbonoSocio, int idEstado )
        {
            string sql = "UPDATE Socio SET fk_IdAbonoSocio = @fk_IdAbonoSocio, fk_IdEstado = @fk_IdEstado WHERE idSocio = @idSocio";
            Object paramList = new { 
                idSocio = idSocio,
                fk_IdEstado=idEstado,
                fk_IdAbonoSocio=idAbonoSocio 
                };

            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;

        }

        
        public List<MedioDePago> GetMediosDePago()
        {
            List<MedioDePago> LstMdp = new List<MedioDePago>();
            string sql = "SELECT idMdp, nombreMdp FROM MediosDePagos";
            LstMdp = dbOperation.OperationQuery<MedioDePago>(sql);
            return LstMdp;
        }

        public List<Pagos> GetHistorialDePagos()
        {
            List<Pagos> lstHistorialPagos = new List<Pagos>();
            string sql = "SELECT IdPago, montoPago, fechaPago, fk_socio_id, fk_Mdp_id, fk_AbonoCobrado_id FROM Pagos";
            lstHistorialPagos=dbOperation.OperationQuery<Pagos>(sql);
            return lstHistorialPagos;
        }
        public int InsertPago(Pagos nuevoPago)
        {
            string sql = "INSERT INTO Pagos (montoPago,fechaPago,fk_Socio_id,fk_Mdp_id,fk_AbonoCobrado_id)" +
                "OUTPUT INSERTED.IdPago " +
                "VALUES(@montoPago,@fechaPago,@fk_Socio_id,@fk_Mdp_id,@fk_AbonoCobrado_id) ";

            object paramList = new
            {
                montoPago = nuevoPago.montoPago,
                fechaPago = nuevoPago.fechaPago,
                fk_Socio_id=nuevoPago.fk_Socio_id,
                fk_Mdp_id=nuevoPago.fk_Mdp_id,
                fk_AbonoCobrado_id=nuevoPago.fk_AbonoCobrado_id
            };

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        public List<PagoDto> GetPagos()
        {
            List<PagoDto> LstPagos = new List<PagoDto>();
            string sql = "SELECT PG.IdPago,PG.montoPago,PG.fechaPago, "
                        + "P.dni,P.nombre,P.apellido,"
                        + "S.IdSocio,"
                        + "ASO.nombreAbono,"
                        + "MDP.nombreMdp "
                        + "FROM Pagos PG "
                        + "INNER JOIN Socio S ON PG.fk_Socio_id = S.IdSocio "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN AbonoSocio ASO ON PG.fk_AbonoCobrado_id = ASO.IdAbonoSocio "
                        + "INNER JOIN MediosDePagos MDP ON PG.fk_Mdp_id = MDP.idMdp";
            LstPagos = dbOperation.OperationQuery<PagoDto>(sql);
            return LstPagos;
        }

        public PagoDto GetPagoById(int idPago)
        {
            PagoDto pago;
            string sql = "SELECT PG.IdPago,PG.montoPago,PG.fechaPago, "
                        + "P.dni,P.nombre,P.apellido,"
                        + "S.IdSocio,"
                        + "ASO.nombreAbono,"
                        + "MDP.nombreMdp "
                        + "FROM Pagos PG "
                        + "INNER JOIN Socio S ON PG.fk_Socio_id = S.IdSocio "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN AbonoSocio ASO ON PG.fk_AbonoCobrado_id = ASO.IdAbonoSocio "
                        + "INNER JOIN MediosDePagos MDP ON PG.fk_Mdp_id = MDP.idMdp "
                        + "WHERE PG.IdPago = @IdPago";
            pago = dbOperation.OperationQueryById2<PagoDto>(sql, new { IdPago = idPago });
            return pago;
        }

        public int EditarFormaDePago(int idPago, int idMdp)
        {
            string sql = "UPDATE Pagos SET fk_Mdp_id = @fk_Mdp_id WHERE IdPago = @IdPago";
            Object paramList = new { IdPago = idPago, fk_Mdp_id = idMdp };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }

        public AbonoSocio GetAbonoSociosById(int idAbonoSocio)
        {
            AbonoSocio abono;
            string sql = "SELECT IdAbonoSocio,nombreAbono,valor FROM AbonoSocio WHERE IdAbonoSocio=@idAbonoSocio";
            abono = dbOperation.OperationQueryById2<AbonoSocio>(sql, new {idAbonoSocio = idAbonoSocio });
            return abono;
        }

        public Pagos GetPagoBySocioId(int idSocio)
        {
            Pagos pago;
            string sql = "SELECT PG.IdPago,PG.montoPago,PG.fechaPago, "
                        + "P.dni,P.nombre,P.apellido,"
                        + "S.IdSocio,"
                        + "ASO.nombreAbono,"
                        + "MDP.nombreMdp "
                        + "FROM Pagos PG "
                        + "INNER JOIN Socio S ON PG.fk_Socio_id = S.IdSocio "
                        + "INNER JOIN Persona P ON S.fk_idPersona = P.idPersona "
                        + "INNER JOIN AbonoSocio ASO ON PG.fk_AbonoCobrado_id = ASO.IdAbonoSocio "
                        + "INNER JOIN MediosDePagos MDP ON PG.fk_Mdp_id = MDP.idMdp "
                        + "WHERE PG.fk_Socio_id = @fk_Socio_id";
            pago = dbOperation.OperationQueryById2<Pagos>(sql, new { fk_Socio_id = idSocio });
            return pago;
        }

        public ActividadAdmin GetActividadById(int idActividad)
        {
            ActividadAdmin actividad;
            string sql = "SELECT ACT.IdActividad,ACT.nombreActividad,ACT.horario,ACT.horasPorSemana,ACT.fk_Profesor_id,fk_Abono_id,ACT.cupoDisponible,"
                        + "AB.valorCuotaPura,AB.nombreAbono,AB.porcentajeEstablecimiento,AB.porcentajeProfesor,"
                        + "P.nombre "
                        + "FROM Actividad ACT "
                        + "LEFT JOIN Abono AB ON ACT.fk_Abono_id = AB.idAbono "
                        + "LEFT JOIN Profesor PR ON ACT.fk_Profesor_id = PR.IdProfesor "
                        + "LEFT JOIN Persona P ON PR.fk_idPersona = P.idPersona "
                        + "WHERE ACT.IdActividad = @IdActividad ";
            actividad = dbOperation.OperationQueryById2<ActividadAdmin>(sql, 
                new
            {
                IdActividad = idActividad
            });
            return actividad;
        }

        public int EditarActividad(Actividad actividad)
        {
            string sql = "UPDATE Actividad SET nombreActividad = @nombreActividad, fk_Abono_id = @fk_Abono_id, horario = @horario,cupoDisponible=@cupoDisponible, "
                +"horasPorSemana = @horasPorSemana, fk_Profesor_id = @fk_Profesor_id " 
                +"WHERE IdActividad = @IdActividad";
            Object paramList = new {
                nombreActividad = actividad.nombreActividad,
                fk_Abono_id = actividad.fk_Abono_id,
                horario = actividad.horario,
                horasPorSemana = actividad.horasPorSemana,
                fk_Profesor_id = actividad.fk_Profesor_id,
                IdActividad = actividad.idActividad,
                cupoDisponible =actividad.cupoDisponible};
            int affectedRows = dbOperation.OperationExecute(sql, paramList);
            return affectedRows;
        }

        public int EditarEstadoProfesor(int idProfesor)
        {
            string sql = "UPDATE Profesor SET fk_IdEstado = @idEstado WHERE IdProfesor = @IdProfesor";
            Object paramList = new { 
                IdProfesor = idProfesor, 
                idEstado = 1 };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }

        public ProfesorAdmin GetProfesorById (int idProfesor)
        {
            ProfesorAdmin profesor;
            string sql = "SELECT PR.IdProfesor,PR.fechaContratacion,PR.sueldo,PR.fk_IdEstado, "
                        + "P.dni,P.nombre,P.apellido,P.telefono,P.direccion,P.mail,"
                        + "E.nombreEstado,"
                        + "ACT.nombreActividad "
                        + "FROM Profesor PR "
                        + "INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona "
                        + "LEFT JOIN Estado E ON PR.fk_IdEstado = E.IdEstado "
                        + "LEFT JOIN Actividad ACT ON PR.IdProfesor = ACT.fk_Profesor_id "
                        + "WHERE PR.IdProfesor = @IdProfesor";

            profesor = dbOperation.OperationQueryById2<ProfesorAdmin>(sql, new { 
                IdProfesor = idProfesor });

            return profesor;
        }

        public List<ActividadAdmin> GetActividadesDelProfesor(int fk_Profesor_id)
        {
            List<ActividadAdmin> actividades = new List<ActividadAdmin>();
            List <int> ids = new List<int>();
            string sqlQuery = "SELECT IdActividad FROM Actividad WHERE "
                               +"fk_Profesor_id=@fk_Profesor_id";
            ids = dbOperation.OperationQuery2<int>(sqlQuery, new
            {
                fk_Profesor_id= fk_Profesor_id
            });
            foreach (int id in ids)
            {
                ActividadAdmin actividad = GetActividadById(id);
                actividades.Add(actividad);
            }
            return actividades;
        }

        public int EditarDatosPersona(Persona personaExistente)
        {
            string sql = "UPDATE Persona SET nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, direccion=@direccion,"
                +"fk_IdGenero=@fk_IdGenero, fechaNacimiento=@fechaNacimiento, mail=@mail "
                +"WHERE IdPersona=@IdPersona";

            object paramList = new
            {
                nombre = personaExistente.nombre,
                apellido = personaExistente.apellido,
                dni = personaExistente.dni,
                telefono = personaExistente.telefono,
                direccion = personaExistente.direccion,
                fk_IdGenero = personaExistente.fk_IdGenero,
                fechaNacimiento = personaExistente.fechaNacimiento,
                mail = personaExistente.mail,
                IdPersona = personaExistente.idPersona
            };

            int affectedRows = dbOperation.OperationExecute(sql, paramList);
            return affectedRows;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> LstUsuarios = new List<Usuario>();
            string sql = "SELECT * FROM Usuario";
            LstUsuarios = dbOperation.OperationQuery<Usuario>(sql);
            return LstUsuarios;
        }

        public List<Roles> ObtenerRoles()
        {
            List<Roles> lstRoles = new List<Roles>();
            string sql = "SELECT IdRol, nombreRol FROM RolUsuario";
            lstRoles = dbOperation.OperationQuery<Roles>(sql);
            return lstRoles;
        }

        public Usuario GetUsuario(int idUser)
        {
            Usuario usuario;
            string sql = "SELECT UR.idUser,UR.nombreUsuario,UR.password,UR.fk_IdRol,UR.fk_PersonaId,"
                          + "P.dni,P.nombre,P.apellido,P.telefono,P.direccion,P.mail,"
                          + "R.IdRol,R.nombreRol "
                          + "FROM Usuario UR "
                          + "LEFT JOIN Persona P ON UR.fk_PersonaId = P.idPersona "
                          + "INNER JOIN RolUsuario R ON UR.fk_IdRol = R.IdRol "
                          + "WHERE UR.idUser = @idUser";

            usuario = dbOperation.OperationQueryById2<Usuario>(sql, new
            {
                idUser = idUser
            });

            return usuario;
        }
        public Usuario GetUsuarioAdmin(int idUser)
        {
            Usuario usuario;
            string sql = "SELECT UR.idUser,UR.nombreUsuario,UR.password,UR.fk_IdRol,UR.fk_PersonaId,"
                          + "P.dni,P.nombre,P.apellido,P.telefono,P.direccion,P.mail,"
                          + "R.IdRol,R.nombreRol "
                          + "FROM Usuario UR "
                          + "INNER JOIN Persona P ON UR.fk_PersonaId = P.idPersona "
                          + "INNER JOIN RolUsuario R ON UR.fk_IdRol = R.IdRol "
                          + "WHERE UR.idUser = @idUser";

                usuario = dbOperation.OperationQueryById2<Usuario>(sql, new
                {
                    idUser = idUser
                });

                return usuario;  
        }

        public int InsertUsuario(Usuario usuarioNuevo)
        {
            string sql = "INSERT INTO Usuario (nombreUsuario,password,fk_IdRol)  Values" +
                        "(@nombreUsuario,@password,@fk_IdRol)";
            Object paramList = new
                {
                    nombreUsuario = usuarioNuevo.nombreUsuario,
                    password = usuarioNuevo.password,
                    fk_IdRol = usuarioNuevo.fk_IdRol,
                };

                int result = dbOperation.OperationExecute(sql, paramList);

                return result;
           
        }

        public int EditarRolUsuario(int idUser, int idRolUsuario)
        {
            string sql = "UPDATE Usuario SET fk_IdRol = @fk_IdRol WHERE idUser = @idUser";
            Object paramList = new
             {
                idUser =idUser,
                fk_IdRol = idRolUsuario
                };

                int affectedRows = dbOperation.OperationExecute(sql, paramList);

                return affectedRows;


        }

        public int EditarPasswordUsuario(int idUser, string password)
        {
            string sql = "UPDATE Usuario SET password = @password WHERE idUser = @idUser";
            Object paramList = new
            {
                idUser = idUser,
                password= password
            };

            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;

        }
    }
}


