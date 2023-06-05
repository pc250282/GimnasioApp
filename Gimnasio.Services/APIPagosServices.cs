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

        public int insertPago(Pago nuevoPago)
        {
            return datosMaestros.InsertPago(nuevoPago);
        }

    }
}
