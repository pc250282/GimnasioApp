using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
    
    public class APIAbonosServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();

        public List<AbonoSocio> getAbonosSocios()
        {
            return datosMaestros.GetAbonoSocios();
        }
    }
}
