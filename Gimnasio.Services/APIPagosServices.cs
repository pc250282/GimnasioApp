using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gimnasio.Clases;
using Gimnasio.Clases.Dto;
using Gimnasio.DataStore;

namespace Gimnasio.Services
{
    public class APIPagosServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();

        public List<MedioDePago> getMediosDePago()
        {
            return datosMaestros.GetMediosDePago();
        }
        public int insertPago(Pagos nuevoPago)
        {
            return datosMaestros.InsertPago(nuevoPago);
        }

        public List<Pagos> getHistorialDePagos()
        {
            return datosMaestros.GetHistorialDePagos();
        }

    }
}
