using Gimnasio.Clases;

namespace GimnasioApp.WebApi.Dto
{
    public class SocioDto
    {
        public int IdSocio { get; set; }
        public string nombreEstado { get; set; }
        public DateTime fechaUltimoPago { get; set; }
        public string nombreAbono { get; set; }

    }
}
