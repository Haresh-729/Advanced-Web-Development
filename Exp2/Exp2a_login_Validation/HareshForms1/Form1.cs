using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareshForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtU.Text))
            {
                //e.Cancel = true;
                txtU.Focus();
                errorProvider1.SetError(txtU, "Please enter your username...!");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtU, null);
            }
            if (string.IsNullOrEmpty(txtP.Text))
            {
                //e.Cancel = true;
                txtP.Focus();
                errorProvider2.SetError(txtP, "Please enter your password...!");
            }
            else
            {
                //e.Cancel = true;
                errorProvider2.SetError(txtP, null);
            }
            if (txtU.Text == "HareshSK" & txtP.Text == "9930112982")
            {
                login ss = new login();
                ss.Show();
            }
            else
            {
                //MessageBox.Show("Username or Password is wrong");
                
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtU.Text = "";
            txtP.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtU_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtP_Validating(object sender, CancelEventArgs e)
        {
            
            
        }
    }
}
