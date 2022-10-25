using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    public partial class GPM420 : Form
    {
        public GPM420()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out...!");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result_display rd = new Result_display();
            rd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under developing.....!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under developing.....!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under developing.....!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under developing.....!");
        }
    }
}
