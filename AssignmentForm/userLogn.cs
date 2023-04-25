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
    public partial class userLogn : Form
    {
       
        DataTable dt = new DataTable();
        public userLogn()
        {
            InitializeComponent();
            

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            AC.username = usernametextbox.Text; //stores the string inside textbox to the variable
            AC.password = passwordtextbox.Text;
            AC.cmd.CommandText = "SELECT * FROM USERS WHERE user_id= '" + AC.username + "' AND user_password = '" + AC.password + "';"; //selects or searches specified column
            AC.cmd.Connection = AC.con; //give connection to the command
            AC.dr = AC.cmd.ExecuteReader();//tells the program to read the database
            if (usernametextbox.Text != "" && passwordtextbox.Text != "")
            {
                if (AC.dr.Read() == true)
                {

                    if (AC.dr["user_id"].ToString() == AC.username && AC.dr["user_password"].ToString() == AC.password)
                    {
                        MessageBox.Show("Succesfully Logged in. Welcome " + AC.dr["user_name"].ToString());
                        useraction useraction = new useraction();
                        this.Hide();
                        useraction.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or Password");

                    }
                }
                else
                {
                    MessageBox.Show("Data not in the database");
                }

            }
            else
            {
                MessageBox.Show("Please input your username or password");
            }

            //else
            //{
            //    MessageBox.Show("Wrong username or Password");

            //}

            AC.dr.Close();
            //AC.da = new OleDbDataAdapter("select Count(*) from login where user_id = '" + usernametextbox.Text + "'and Password = '" + passwordtextbox.Text + "'", AC.con);
            //AC.da.Fill(dt);
            //if (dt.Rows.Count <= 0/*[0][0].ToString() == "1"*/)
            //{
            //    MessageBox.Show("The username or password is incorrect");
            //}
            //else if ((String.IsNullOrEmpty(this.usernametextbox.Text.Trim())) &&
            //    (String.IsNullOrEmpty(this.passwordtextbox.Text.Trim())))
            //{
            //    MessageBox.Show("Please input your username and password");
            //}
            //else
            //{
            //    useraction useraction = new useraction();
            //    this.Hide();
            //    useraction.Show();
            //}
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            selection selection = new selection();
            selection.Show();
            this.Hide();

        }
        
        private void userLogn_Load(object sender, EventArgs e)
        {
            AC con = new AC();
            //open connection

            AC.openConnection();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (showPassword.Checked == true)
            {
                 passwordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = true;
            
            }

        }
    }
}
