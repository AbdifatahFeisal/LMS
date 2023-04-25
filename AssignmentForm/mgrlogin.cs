using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AssignmentForm
{
    public partial class mgrlogin : Form
    {
        //OleDbConnection cnnOLEDB = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\database\\AssignmentDatabase.accdb");
        //OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        //cnnOLEDB.ConnectionString = "";
        //cnnOLEDB.Open();
        
        
        
        public mgrlogin()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AC.username = useridtextBox.Text; //stores the string inside textbox to the variable
            AC.password = pwordtextBox.Text;
            AC.cmd.CommandText = "SELECT * FROM MANAGERS WHERE manager_id= '" + AC.username + "' AND manager_pword = '" + AC.password + "';"; //selects or searches specified column
            AC.cmd.Connection = AC.con; //give connection to the command
            AC.dr = AC.cmd.ExecuteReader();//tells the program to read the database
            if (useridtextBox.Text != "" && pwordtextBox.Text != "")
            {
                if (AC.dr.Read() == true)
                {

                    if (AC.dr["manager_id"].ToString() == AC.username && AC.dr["manager_pword"].ToString() == AC.password)
                    {
                        MessageBox.Show("Succesfully Logged in. Welcome Manager\n" + AC.dr["manager_name"].ToString());
                        mgraction mgraction = new mgraction();
                        this.Hide();
                        mgraction.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or Password");

                    }
                }
                else
                {
                    MessageBox.Show("Please Input Correct Details");
                }

            }
            else
            {
                MessageBox.Show("Please input your username or password");
            }

            AC.dr.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AC con = new AC();
            //open connection

            AC.openConnection();//
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            selection selection = new selection();
            selection.Show();
            this.Hide();
        }

        private void showpasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCheckBox.Checked)
            {
                pwordtextBox.UseSystemPasswordChar = false;

            }
            else
            {
                pwordtextBox.UseSystemPasswordChar = true;
            }

        }
    }
}
