using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment4
{
    public partial class Form1 : Form
    {
        public static string enrol;
        public static string std;
        public static int en, h, m, ma, s;
        public static string percentage, total1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label16.Text = enrol;
            label17.Text = std;
            label11.Text = total1;
            label12.Text = percentage;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Results r1 = new Results();
            enrol =textBox1.Text;
            std = textBox2.Text;
            en = int.Parse(textBox3.Text);
            h = int.Parse(textBox4.Text);
            m = int.Parse(textBox5.Text);
            ma = int.Parse(textBox6.Text);
            s = int.Parse(textBox7.Text);
            total1 = r1.GetMarks(en, h, m, ma, s);
            percentage = r1.percent();
            MessageBox.Show("Data Entered...!");
        }
    }
}
