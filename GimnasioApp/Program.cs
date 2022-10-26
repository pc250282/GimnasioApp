// See https://aka.ms/new-console-template for more information

using Gimnasio.Clases;
using Gimnasio.DataStore;




//Aca creamos instancias que vamos a utilizar para probar los metodos del establecimiento
Socio socioNuevo = new Socio() {
    idSocio = 1,
    nombre = "Pablo",
    apellido = "Calvo",
    dni = "35994686",
    telefono = "1543567890",
    fechaNacimiento = new DateOnly(1991, 12, 31),
    direccion = "Cavour 3006",
    estadoDelSocio = new Estado(2),
    fechaInscripcion=DateTime.Now
    
};

Profesor profesorNuevo = new Profesor() {
    numLegajo=223,
    nombre="Victor",
    apellido="Cordero",
    dni="56878343",
    telefono="11738873",
    direccion="Calle 178",
    fechaNacimiento = new DateOnly(1987,06,19),
    actividad="Profesor de musculacion",
    sueldo=10500.00,
    estadoProfesor=new Estado(1)
};



var lstProfesores = new List<Profesor>() {
    new Profesor(){numLegajo=1,nombre="Juan",apellido="Lopez",dni="30234987",telefono="1134567627", fechaNacimiento=new DateOnly(1980, 05, 21), direccion="J.Hernandez 1800",actividad="Profesor de Zumba",sueldo=4500.00, estadoProfesor=new Estado(1) },
    new Profesor(){numLegajo=2,nombre="Hernan",apellido="Hernandez",dni="20254687",telefono="1143437627", fechaNacimiento=new DateOnly(1950, 10, 01), direccion="Av.Santa fe 180",actividad="Profesor de Pilates",sueldo=1500.00,estadoProfesor=new Estado(2) }
};

var lstSocio = new List<Socio>()
{
    new Socio(){idSocio=20,nombre="Luciano",apellido="Calvo",dni="29378456",telefono="113342233",fechaNacimiento=new DateOnly(1980, 05, 21),fechaInscripcion=DateTime.Now,estadoDelSocio=new Estado(1)},
    new Socio(){idSocio=46,nombre="Jorge",apellido="Calvo",dni="12378456",telefono="42760263",fechaNacimiento=new DateOnly(1980, 05, 21),fechaInscripcion=DateTime.Now,estadoDelSocio=new Estado(3)}
};



//Aca creamos la intantancia del establecimiento con todos los componentes necesarios
Establecimiento establecimiento = new Establecimiento { 
    idGimnasio=1,
    nombreGimnasio="Argentino GYM",
    cuotaMensual=5000.00,
    LstProfesores=lstProfesores,
    LstSocios=lstSocio,
};

Console.WriteLine(establecimiento.mostrarDatos());
Console.WriteLine("*****************************************************");
establecimiento.mostrarProfesores();
Console.WriteLine("*****************************************************");
establecimiento.mostrarSocios();
Console.WriteLine("*****************************************************");
Console.WriteLine(lstSocio[0].ToString());

//Utilizamos metodos del gimnasio para validar

Console.WriteLine(establecimiento.registroEnGimnasio(socioNuevo));
Console.WriteLine("*****************************************************");
Console.WriteLine(establecimiento.registroEnGimnasio(profesorNuevo));
establecimiento.mostrarSocios();
Console.WriteLine("*****************************************************");
establecimiento.mostrarProfesores();







/*
  int idPersona;
  Persona socioCreado;
  DatosMaestros datosMaestros=new DatosMaestros();

lstSocios = datosMaestros.GetSocios();
foreach(Socio socio in lstSocios)
{
    Console.WriteLine(socio.dni);
    idPersona = socio.idSocio;
    socioCreado=datosMaestros.GetSociosData(idPersona);
    Console.WriteLine("Socio N°" + socioCreado.fk_IdSocio);
    Console.WriteLine(socioCreado.nombre);
    Console.WriteLine(socio.fk_IdGenero);
}
*/



