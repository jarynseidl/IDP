using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class eWFMConn
    {
        private static eWFMConn Singleton;

        public static eWFMConn getSingleton()
        {
            if (Singleton == null)
            {
                Singleton = new eWFMConn();
            }
            return Singleton;
        }

        private eWFMConn()
        {
            String connString = "Data Source=SQLINFWWDVP59\\DCPRD59;Integrated Security=False;User ID=workforceuser;Password=Frontier1;";
            conn = new SqlConnection(connString);
            System.Console.WriteLine(conn.ConnectionString);
            try
            {
                conn.Open();
                System.Console.WriteLine("Connected!!!");
                conn.CreateCommand();
                conn.Close();

            }catch(Exception e)
            {
                System.Console.WriteLine("Problem Connecting");
                System.Console.WriteLine(e.Message);
            }
        }

        protected SqlConnection conn;

        
    }
}
