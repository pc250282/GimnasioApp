using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.DataStore
{
    public class DBOperation
    {
        private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc250282\source\repos\GimnasioApp\Gimnasio.DataStore\BBDD\DBGym.mdf;Integrated Security=True;Connect Timeout=30";
        //private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pablo\source\repos\GimnasioApp\Gimnasio.DataStore\BBDD\DBGym.mdf;Integrated Security=True;Connect Timeout=30";
        //private string ConnectionString = @"workstation id=DBGymPablo.mssql.somee.com;packet size=4096;user id=pabloelgranate_SQLLogin_2;pwd=63ao6wcu9f;data source=DBGymPablo.mssql.somee.com;persist security info=False;initial catalog=DBGymPablo";
        public List<T> OperationQuery<T>(string sqlQuery)
        {
            List<T> LstResult;
            using (var connection = new SqlConnection(ConnectionString))
            {
                LstResult = connection.Query<T>(sqlQuery).ToList();
            }
            return LstResult;
        }

        public T OperationQueryById<T>(string sqlQuery)
        {
            T result;
            using (var connection = new SqlConnection(ConnectionString))
            {
                result = connection.Query<T>(sqlQuery).First();
            }
            return result;
        }
        public T OperationQueryById2<T>(string sqlQuery, object paramList)
        {
            T result;
            using (var connection = new SqlConnection(ConnectionString))
            {
                result = connection.Query<T>(sqlQuery, paramList).First();
            }
            return result;
        }

        public int OperationExecute(string SQLExecute, object paramList)
        {
            int affectedRows;
            using (var connection = new SqlConnection(ConnectionString))
            {
                affectedRows = connection.Execute(SQLExecute, paramList);
            }
            return affectedRows;
        }

        public int OperationExecuteWithIdentity(string SQLExecute, object paramList)
        {
            int identity;
            using (var connection = new SqlConnection(ConnectionString))
            {
                identity = connection.ExecuteScalar<int>(SQLExecute, paramList);
            }
            return identity;
        }

    }
}
