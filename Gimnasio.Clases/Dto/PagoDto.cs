using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases.Dto
{
    public class PagoDto
    {
        public int IdPago { get; set; }
        public float montoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int dni { get; set; }
        public int IdSocio { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreAbono { get; set; }
        public string nombreMdp { get;set; }
        

    }
}
