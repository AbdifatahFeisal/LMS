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
    public partial class userRenew : Form
    {

        
        public userRenew()
        {
            InitializeComponent();
        }


        private void Renew_Load(object sender, EventArgs e)
        {
            AC con = new AC();
            //open connection

            AC.openConnection();//

        }

        private void renewbutton_Click(object sender, EventArgs e)
        {
            
            DateTime DateToday = DateTime.Now.Date;
            string id = bookidtextbox.Text;
            ComparingDate.DateCompare(ref id);
            int value = DateTime.Compare(DateToday, ComparingDate.Dreturn);
            if (value <= 0)
            {
                string idate = dateTimePicker1.Value.ToString("MM/dd/yyyy");

                AC.cmd.CommandText = "Update borrowbookdb Set DateofReturn = \'" + idate + "\' where BookID= \'" + bookidtextbox.Text + "\' ;";
                AC.cmd.CommandType = CommandType.Text;
                AC.cmd.Connection = AC.con;
                AC.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            else
            {
                MessageBox.Show("Invalid Renewal.\n Book is " + value + " day(s) overdue.");
            }
            
        }

        

        private void searchbutton_Click(object sender, EventArgs e)
        {
            AC.cmdSearch.CommandText = "Select * From memberdb Where member_id = \'" + memberidtextbox.Text + "\';";
            AC.cmdSearch.Connection = AC.con;
            OleDbDataReader dr = AC.cmdSearch.ExecuteReader();
            if (dr.Read() == true)
            {
                nametextbox.Text = dr[1].ToString();
                statustextbox.Text = dr[2].ToString();
                itemtextbox.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Member ID is not available in Database");
            }
            dr.Close();
            {
                AC.cmd.CommandText = "Select * From borrowbookdb Where MemberID = \'" + memberidtextbox.Text + "\';";
                AC.cmd.Connection = AC.con;
                OleDbDataAdapter da = new OleDbDataAdapter(AC.cmd);
                DataTable f = new DataTable();
                da.Fill(f);
                dataGridView1.DataSource = f;
            }
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            AC.cmdSearch.CommandText = "Select * From bookdb Where bookid = \'" + bookidtextbox.Text + "\';";
            AC.cmdSearch.Connection = AC.con;
            OleDbDataReader dr = AC.cmdSearch.ExecuteReader();
            if (dr.Read() == true)
            {
                typetextbox.Text = dr[1].ToString();
                titletextbox.Text = dr[2].ToString();
                loandurationtextbox.Text = dr[3].ToString();

            }
            else
            {
                MessageBox.Show("Book ID is not available in Database");
            }
            dr.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            useraction useraction = new useraction();
            useraction.Show();
            this.Hide();
        }
    }
}
