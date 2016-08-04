using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    class DBConnector
    {
        SqlConnection con;

        public DBConnector()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=FinalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        
        public SqlConnection getConnection()
        {
            return con;
        }

    }
}
