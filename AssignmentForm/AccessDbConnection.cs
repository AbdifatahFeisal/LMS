using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace AssignmentForm
{
    class AC
    {
        public static string username;
        public static string password;
        public static OleDbConnection con = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbDataReader dr;
        public static OleDbDataAdapter adp = new OleDbDataAdapter();
        public static OleDbCommand cmdDelete = new OleDbCommand();
        public static OleDbCommand cmdSearch = new OleDbCommand();
        public static OleDbCommand cmdUpdate = new OleDbCommand();

        public static string getConnectionString()
        {
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\Assignment2\Assignment2\bin\Debug\AssignmentDatabase.accdb
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= ioop_assignment.accdb;";

            return connectionString;
        }
       
        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = getConnectionString();
                    con.Open();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Connection has failed");
            }
        }
        
    }
}
