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
    public partial class mgrborrow : Form
    {
        DateTime D1;
        public mgrborrow()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string memID = MemberIDTextBox.Text;
            MaxBorrow.getMaxAmount(ref memID);
            MaxBorrow.getMaxAmountFromBorrowBook(ref memID);
            //getMaxAmount();
            //getMaxAmountFromBorrowBook();
            try
            {
                if (MaxBorrow.BorrowLimit > MaxBorrow.TotalBorrow)
                {
                    DateTime d1 = DateTime.Parse(BorrowDateTextBox.Text);
                    TimeSpan days = TimeSpan.Parse(LoanDurationTextBox.Text);
                    CalculateReturnDate.DateReturnCal(ref days, ref d1);
                    //DateTime D2;
                    //TimeSpan Days;
                    //Days = TimeSpan.Parse(LoanDurationTextBox.Text);
                    //D1 = DateTime.Parse(BorrowDateTextBox.Text);
                    //D2 = D1 + Days;
                    string s = "";
                    if (BookComboBox.SelectedIndex >= 0)
                    {
                        s = BookComboBox.Items[BookComboBox.SelectedIndex].ToString();
                        string q = "insert into borrowbookdb values('" + TitleTextBox.Text + "','" + BookIDTextBox.Text + "','" + MemberIDTextBox.Text + "','" + MemberNameTextBox.Text + "','" + BorrowDateTextBox.Text + "','" + CalculateReturnDate.D2.ToString("MM/dd/yyyy") + "','" + LoanDurationTextBox.Text + "')";
                        AC.cmd = new OleDbCommand(q, AC.con);
                        AC.cmd.ExecuteNonQuery();
                        MessageBox.Show(MemberNameTextBox.Text + ", You have borrowed 《" + TitleTextBox.Text + "》, Please return or renew the book before " + LoanDurationTextBox.Text + " days.");
                    }
                    else
                    {
                        MessageBox.Show("Please select the book that you want to borrow.");
                    }
                }
                if (MaxBorrow.BorrowLimit <= MaxBorrow.TotalBorrow)
                {
                    MessageBox.Show("The member has reached limit to borrow books.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please insert the valid information for completing the borrowing operation.");
            }
        }

        private void BookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AC.cmd = new OleDbCommand("Select * From bookdb where title=@title", AC.con);
            AC.cmd.Connection = AC.con;
            AC.cmd.Parameters.AddWithValue("@title", BookComboBox.Text);
            AC.dr = AC.cmd.ExecuteReader();
            if (AC.dr.Read())
            {
                BookIDTextBox.Text = AC.dr[0].ToString();
                TypeTextBox.Text = AC.dr[1].ToString();
                TitleTextBox.Text = AC.dr[2].ToString();
                LoanDurationTextBox.Text = AC.dr[3].ToString();
            }
            AC.dr.Close();
        }

        private void mgrborrow_Load(object sender, EventArgs e)
        {
            AC.openConnection();
            OleDbCommand cmd = new OleDbCommand("select * from bookdb", AC.con);
            OleDbDataReader odr = null;
            odr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(odr);
            BookComboBox.DataSource = table;
            BookComboBox.BindingContext = this.BindingContext;
            BookComboBox.DisplayMember = "title";
            BookComboBox.ValueMember = "bookid";
            BorrowDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            AC.dr.Close();
        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            AC.cmd = new OleDbCommand("Select * From memberdb where member_id=@memberID", AC.con);
            AC.cmd.Connection = AC.con;
            AC.cmd.Parameters.AddWithValue("@memberID", MemberIDTextBox.Text);
            AC.dr = AC.cmd.ExecuteReader();
            if (AC.dr.Read())
            {
                MemberNameTextBox.Text = AC.dr[1].ToString();
            }
            AC.dr.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mgraction mgraction = new mgraction();
            mgraction.Show();
            this.Hide();
        }
    }
}
