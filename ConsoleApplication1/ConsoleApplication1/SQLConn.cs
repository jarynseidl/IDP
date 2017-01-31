using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class SQLConn
    {
        private static SQLConn instance;

        private SQLConn(String server, String db, String uName, String pw, bool trusted) {
            SqlConnection cnn;
            String connString = null;
            if (trusted)
            {
                connString = "Data Source=" + server + ";Initial Catalog=" + db + ";Integrated Security=SSPI;";
            }
            else
            {
                connString = "Data Source=" + server + ";Initial Catalog=" + db + ";User ID=" + uName + ";Password=" + pw + ";";
            }

            cnn = new SqlConnection(connString);
            try
            {
                cnn.Open();
                System.Console.WriteLine("Connected!!!");
                cnn.Close();
            }catch(Exception e)
            {
                System.Console.WriteLine("Problem Connecting");
            }
        }
        public static SQLConn getSingleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLConn();
                }
                return instance;
            }
        }
    }
}
