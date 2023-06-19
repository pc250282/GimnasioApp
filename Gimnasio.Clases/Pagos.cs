using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Pagos
    {
        public int idPago { get; set; }
        public float montoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int fk_Socio_id { get; set; }
        public int fk_Mdp_id { get; set; }
        public int fk_AbonoCobrado_id { get; set; }



    }
}
