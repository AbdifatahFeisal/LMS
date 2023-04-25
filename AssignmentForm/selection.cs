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
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void managerbutton_Click(object sender, EventArgs e)
        {
            mgrlogin form1 = new mgrlogin();
            form1.Show();
            this.Hide();

        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            userLogn userLogn = new userLogn();
            userLogn.Show();
            this.Hide();
        }

        private void selection_Load(object sender, EventArgs e)
        {
            
        }
    }
}
