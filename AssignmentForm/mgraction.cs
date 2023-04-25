using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentForm
{
    public partial class mgraction : Form
    {
        public mgraction()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentDatabaseDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.assignmentDatabaseDataSet.login);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mgrRenew mgrrenew = new mgrRenew();
            mgrrenew.Show();
            this.Hide();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            mgrborrow mgrborrow = new mgrborrow();
            mgrborrow.Show();
            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            mgrreturn mgrretrn = new mgrreturn();
            mgrretrn.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }
    }
}
