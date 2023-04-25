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
    public partial class Reports : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdOLEDB = new OleDbCommand();
        public Reports()
        {
            InitializeComponent();
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            cmdOLEDB.CommandText = "Select * From borrowbookdb Where DateofBorrow = '" + dateTimePicker1.Value.ToShortDateString() + "';";
            cmdOLEDB.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdOLEDB);
            DataTable f = new DataTable();
            da.Fill(f);
            dataGridView1.DataSource = f;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = ioop_assignment.accdb";
            cnnOLEDB.Open();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            mgraction mgraction = new mgraction();
            mgraction.Show();
            this.Hide();
        }

        private void displayallbutton_Click(object sender, EventArgs e)
        {
            cmdOLEDB.CommandText = "Select * From borrowbookdb;";
            cmdOLEDB.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdOLEDB);
            DataTable f = new DataTable();
            da.Fill(f);
            dataGridView1.DataSource = f;
        }
    }
}
