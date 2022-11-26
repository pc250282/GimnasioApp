SELECT ACT.idActividad, ACT.nombreActividad,ACT.cupo,ACT.horario,
AB.valorCuotaPura,AB.nombreAbono,
P.nombre,
PR.fk_idPersona
FROM Actividad ACT
INNER JOIN Abono AB ON ACT.fk_idAbono = AB.idAbono
INNER JOIN Persona P ON PR.fk_idPersona = P.idPersona 

