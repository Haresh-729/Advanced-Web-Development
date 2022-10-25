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
    public partial class Result_display : Form
    {
        public Result_display()
        {
            InitializeComponent();
        }

        public string sum()
        {
            int total;
            total = Result.english + Result.hindi + Result.marathi + Result.maths + Result.science + Result.history + Result.geography;
            Console.WriteLine(total);
            return total.ToString();
        }

        public string percentage()
        {
            int per;
            int sum,s;
            sum= Result.english + Result.hindi + Result.marathi + Result.maths + Result.science + Result.history + Result.geography;
            s = sum * 100;
            per = s/ 700;
            return per.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sum1;
            if (textBox1.Text == Result.enrollment)
            {

                Result_display rd2 = new Result_display();
                sum1=rd2.sum();
                label2.Text = sum1;
                label5.Text = percentage();
                textBox2.Text = Result.name;
                textBox3.Text = Result.semester;
                textBox4.Text = Result.year;

            }
            else
            {
                MessageBox.Show("Enter proper username");
            }
            
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            /*if (Result.enrollment)
            {

            }*/
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
