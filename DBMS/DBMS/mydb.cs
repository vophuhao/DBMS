using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    

    internal class mydb
    {

        
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LUL4FFK\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True;Encrypt=Falserrr");

            // get the connection
            public SqlConnection getConnection
            {
                get
                {
                    return con;
                }
            }


            // open the connection
            public void openConnection()
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }

            }


            // close the connection
            public void closeConnection()
            {
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }

            }
        }
    }

