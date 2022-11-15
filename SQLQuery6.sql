select A.nombreActividad, A.fk_idAbono,
AB.valorCuotaPura,porcentajeProfesor
FROM Actividad A
INNER JOIN Abono AB on A.fk_idAbono= AB.idAbono

SELECT PR.idProfesor,PR.fechaContratacion,PR.sueldo,
                        P.nombre,P.apellido,
                        E.nombreEstado, 
                        A.nombreActividad, 
                        AB.valorCuotaPura,porcentajeProfesor 
                        FROM Profesor PR 
                        INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona 
                        INNER JOIN Estado E ON PR.fk_IdEstado = E.IdEstado 
                        INNER JOIN Actividad A ON PR.fk_idActividad = A.idActividad 
                        INNER JOIN Abono AB on A.fk_idAbono= AB.idAbono


