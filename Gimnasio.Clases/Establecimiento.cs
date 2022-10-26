using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Establecimiento
    {
        public int idGimnasio { get; set; }
        public string nombreGimnasio { set; get; }
        public double cuotaMensual { set; get; }

        public List<Socio> LstSocios = new List<Socio> { };

        public List<Profesor> LstProfesores = new List<Profesor>();

        public string registroEnGimnasio(Socio socioAregistrar)
           {
            this.LstSocios.Add(socioAregistrar);
            return "El socio "+socioAregistrar.nombre+" se registro correctamente";
           }

        public string registroEnGimnasio(Profesor profesorAregistrar)
           {
            this.LstProfesores.Add(profesorAregistrar);
            return "El profesor" + profesorAregistrar.nombre + " se registro como empleado en el gimnasio";
           }

        public string movimientoContable(double importe, Socio socioPago)
          {
            return "El socio N°" + socioPago.idSocio + " realizo un el pago de " + importe;
          }

        public string movimientoContable(double importe, Profesor profesorAcobrar)
         {
            return "Se le abono al profesor " + profesorAcobrar.numLegajo + " la suma de " + importe;
         }
        
        public string mostrarDatos()
        {
            return @$"ID:{idGimnasio}{Environment.NewLine}NOMBRE:{nombreGimnasio}{Environment.NewLine}CUOTA MENSUAL:{cuotaMensual}{Environment.NewLine}";
            
        }
        public void mostrarProfesores()
        {
            foreach (Profesor profesor in this.LstProfesores)
            {
                Console.WriteLine("N° de legajo: " + profesor.numLegajo);
                Console.WriteLine("Nombre: " + profesor.nombre);
                Console.WriteLine("Apellido: " + profesor.apellido);
                Console.WriteLine("Actividad: " + profesor.actividad);
                Console.WriteLine(profesor.estadoProfesor.getEstado());
                Console.WriteLine("-------------------------------");
            }
        }

        public void mostrarSocios()
        {
            foreach(Socio socio in this.LstSocios)
            {
                Console.WriteLine("N° de socio: "+socio.idSocio);
                Console.WriteLine("Nombre: " + socio.nombre);
                Console.WriteLine("Apellido: " + socio.apellido);
                Console.WriteLine("Fecha de nacimiento " + socio.fechaNacimiento.ToString());
                Console.WriteLine("Fecha de incripcion: " + socio.fechaInscripcion.ToString());
                Console.WriteLine(socio.estadoDelSocio.getEstado());
                Console.WriteLine("-------------------------------");
            }
        }

    }
}