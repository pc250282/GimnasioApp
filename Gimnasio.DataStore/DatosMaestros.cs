using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using Gimnasio.Clases;

namespace Gimnasio.DataStore
{
    public class DatosMaestros
    {
        DBOperation dbOperation = new DBOperation();
        public Persona GetSociosData(int idSocio)
        {
            List<Persona> LstPersonas = new List<Persona>();
            string sql = "SELECT * FROM Socio INNER JOIN Persona on Persona.fk_idSocio=" + idSocio;
            LstPersonas = dbOperation.OperationQuery<Persona>(sql);
            Persona currentPerson = LstPersonas[0];
            return currentPerson;
        }

        public List<Socio> GetSocios()
        {
            List<Socio> LstSocios = new List<Socio>();
            string sql = "SELECT * FROM Socio";
            LstSocios = dbOperation.OperationQuery<Socio>(sql);
            return LstSocios;
        }

        
        }
}


