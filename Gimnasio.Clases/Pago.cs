using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Pago
    {
        public int idPago { get; set; }
        public float montoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int fk_idSocio { get; set; }
        public int fk_idMdp { get; set; }
        public AbonoSocio fk_AbonoSocio { get; set; }



    }
}
