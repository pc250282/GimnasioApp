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

        public AbonoSocio getAbonoById(int idAbonoSocio)
        {
            return datosMaestros.GetAbonoSociosById(idAbonoSocio);
        }

        public List<TipoIva> getTipoIva()
        {
            return datosMaestros.GetIva();

        }

        public int insertMembresia(AbonoSocio membresia)
        {
            return datosMaestros.InsertMembresia(membresia);
        }

        public int editarMembresia(int idAbonoSocio, double valor)
        {
            return datosMaestros.EditarMembresia(idAbonoSocio, valor);
        }
        
    }
}
