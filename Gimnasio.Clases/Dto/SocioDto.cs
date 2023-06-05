using Gimnasio.Clases;

namespace Gimnasio.Clases.Dto
{
    public class SocioDto
    {
        public int IdSocio { get; set; }
        public int fk_IdEstado { get; set; }
        public DateTime fechaUltimoPago { get; set; }
        public int fk_IdAbonoSocio { get; set; }

    }
}
