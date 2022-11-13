SELECT PR.idProfesor,PR.fechaContratacion,
P.nombre,P.apellido,
E.nombreEstado, 
A.nombreActividad 
FROM Profesor PR 
INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona 
INNER JOIN Estado E ON PR.fk_IdEstado = E.IdEstado 
INNER JOIN Actividad A ON PR.fk_idActividad = A.idActividad