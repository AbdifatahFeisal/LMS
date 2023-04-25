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
    public partial class mgrreturn : Form
    {
        DateTime DateToday = DateTime.Now.Date;
        DateTime DateReturn;
        public mgrreturn()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AC.openConnection();
            AC.cmd = new OleDbCommand("Select * From borrowbookdb where MemberID=@memberid", AC.con);
            AC.cmd.Parameters.AddWithValue("@memberid", MemberIDTextBox.Text);
            AC.dr = null;
            AC.dr = AC.cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(AC.dr);
            BookTitleComboBox.DataSource = table;
            BookTitleComboBox.BindingContext = this.BindingContext;
            BookTitleComboBox.DisplayMember = "Title";
            BookTitleComboBox.ValueMember = "MemberID";
            AC.dr.Close();
            AC.con.Close();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            //CompareDate();
            string title = BookTitleComboBox.Text;
            CompareDate.DateCompare(ref title);
            int value = DateTime.Compare(DateToday, CompareDate.DateReturn);
            if (value <= 0)
            {
                AC.openConnection();
                AC.cmdSearch = new OleDbCommand("Select * From borrowbookdb where Title=@title", AC.con);
                AC.cmdSearch.Parameters.AddWithValue("@title", BookTitleComboBox.Text);
                AC.dr = AC.cmd.ExecuteReader();
                if (AC.dr.Read())
                {
                    var idParam = new OleDbParameter("@title", BookTitleComboBox.Text);
                    AC.cmdDelete.CommandText = "DELETE FROM borrowbookdb WHERE (Title) = @title";
                    AC.cmdDelete.Parameters.Add(idParam);
                    AC.cmdDelete.Connection = AC.con;
                    AC.cmdDelete.ExecuteNonQuery();
                }
                MessageBox.Show("Your book is successfully returned, thanks for borrowing.");
                AC.con.Close();
            }
            else
            {
                AC.openConnection();
                TimeSpan Days;
                Days = CompareDate.DateReturn - DateToday;
                MessageBox.Show("Your fine for overdue is = RM" + Days.ToString("dd"));
                AC.cmdSearch = new OleDbCommand("Select * From borrowbookdb where Title=@title", AC.con);
                AC.cmdSearch.Parameters.AddWithValue("@title", BookTitleComboBox.Text);
                AC.dr = AC.cmd.ExecuteReader();
                if (AC.dr.Read())
                {
                    var idParam = new OleDbParameter("@title", BookTitleComboBox.Text);
                    AC.cmdDelete.CommandText = "DELETE FROM borrowbookdb WHERE (Title) = @title";
                    AC.cmdDelete.Parameters.Add(idParam);
                    AC.cmdDelete.Connection = AC.con;
                    AC.cmdDelete.ExecuteNonQuery();
                }
                MessageBox.Show("Your book is successfully returned, thanks for borrowing.");
                AC.con.Close();
            }
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mgraction mgraction = new mgraction();
            mgraction.Show();
            this.Hide();
        }
    }
}
