namespace Gimnasio.Clases
{
    public class Socio : Persona
    {
        public int idSocio { get; set; }
        public DateTime fechaDeInscripcion { get; set; }
        public Estado fk_IdEstado { get; set; }
        public DateTime fechaUltimoPago { get; set; }
        public int fk_idPersona { get; set; }
        public int fk_IdAbonoSocio { get; set; }




       

        public override string ToString()
        {
            return "SOCIO N°:" + this.idSocio + " NOMBRE:" + this.nombre + " APELLIDO:" + this.apellido + " ESTADO: ";
        }


    }
}
