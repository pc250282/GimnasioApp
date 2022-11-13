namespace Gimnasio.Clases
{
    public class Actividad
    {
        public int idActividad { get; set; }
        public string nombreActividad { set; get; }
        public string horario { set; get; }
        public int fk_idAbono { get; set; }
        public int cupo { get; set; }

    }
}
