using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;

namespace wetubeAPI.Controllers
{
    public class DBConnectionManager
    {
        public SqlConnection OpenConnection()
        {
            var connection = new SqlConnection("user id=Cajoal;" +
                                       "password=Strato17;" +
                                       "server=wetubedqlserver.database.windows.net; " +
                                       "Trusted_Connection=false;Encrypt=True;" +
                                       "database=weTubeDB; " +
                                       "connection timeout=30");

            connection.Open();
            System.Console.WriteLine("returning from open connection");
            return connection;
        } 
    }
}