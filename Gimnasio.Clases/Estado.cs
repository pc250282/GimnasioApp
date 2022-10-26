using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Estado
    {
        int idEstado { get; set; }
        string estado { get; set; }


        public Estado(int idEstado)
        {
            this.idEstado = idEstado;
        }
        
        public string getEstado()
        {
            string mensaje;
           if(idEstado == 1)
            {
                mensaje = "ACTIVO";
                
            }
            else if(idEstado == 2)
            {
                mensaje = "INACTIVO";
            }else if(idEstado == 3)
            {
                mensaje = "DEUDOR";
            }
            else
            {
                mensaje = "Dato desconocido";
            }

           return mensaje;
        }
    }
}
