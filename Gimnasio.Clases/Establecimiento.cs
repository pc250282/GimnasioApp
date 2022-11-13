namespace Gimnasio.Clases
{
    public class Establecimiento
    {
        public int idGimnasio { get; set; }
        public string nombreGimnasio { set; get; }
        public double cuotaMensual { set; get; }

        public List<Socio> LstSocios = new List<Socio> { };

        public List<Profesor> LstProfesores = new List<Profesor>();

    }
}