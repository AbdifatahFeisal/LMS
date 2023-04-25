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
    public partial class useraction : Form
    {
        public useraction()
        {
            InitializeComponent();
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            userborrow borrow = new userborrow();
            borrow.Show();
            this.Hide();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            userreturn retrn = new userreturn();
            retrn.Show();
            this.Hide();
        }

        private void renewbutton_Click(object sender, EventArgs e)
        {
            userRenew Renew = new userRenew();
            Renew.Show();
            this.Hide();
        }

        private void useraction_Load(object sender, EventArgs e)
        {

        }
    }
}
