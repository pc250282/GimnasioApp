namespace Gimnasio.Clases
{
    public class Profesor : Persona
    {
        public int idProfesor { get; set; }
        public DateTime fechaContratacion { get; set; }
        public int fk_idActividad { get; set; }
        public int mesesAntiguedad { get; set; }
        public double sueldo { get; set; }
        public int fk_idEstado { get; set; }

    }
}
