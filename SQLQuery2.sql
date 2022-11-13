SELECT S.idSocio,S.fechaDeInscripcion,P.dni, P.nombre, P.apellido,P.telefono,E.nombreEstado,
PG.fechaPago
FROM  Socio S 
INNER JOIN Persona P ON S.fk_idPersona = P.idPersona
INNER JOIN Estado E ON S.fk_idEstado = E.IdEstado
INNER JOIN IngresosPagos PG ON PG.idPago = S.idSocio