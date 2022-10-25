using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    
    public partial class Result : Form
    {
        public static int english, hindi, marathi, maths, science, history, geography;
        public static string enrollment, name, semester, year;
        public Result()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            /*Regex reg = new Regex("^[0-9]$");
            bool result = reg.IsMatch(textBox6.Text); */

            english = int.Parse(textBox4.Text);
            hindi = int.Parse(textBox6.Text);
            marathi = int.Parse(textBox7.Text);
            maths = int.Parse(textBox8.Text);
            science = int.Parse(textBox9.Text);
            history = int.Parse(textBox10.Text);
            geography = int.Parse(textBox11.Text);
            enrollment = textBox1.Text;
            name = textBox2.Text;
            semester = textBox3.Text;
            year = textBox5.Text;
            Result_display rd1 = new Result_display();
            rd1.Show();

            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
