namespace Gimnasio.Clases
{
    public class Actividad
    {
        public int idActividad { get; set; }
        public string nombreActividad { set; get; }
        public string horario { set; get; }
        public int fk_Abono_id { get; set; }
        public int horasPorSemana { get; set; }
        public int fk_Profesor_id { get; set; }
        public int cupoUtilizado {get; set; }
        public int cupoDisponible { get; set; }

    }
}
