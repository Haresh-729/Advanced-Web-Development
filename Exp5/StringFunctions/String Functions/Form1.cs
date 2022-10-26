using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Functions
{
    public partial class Form1 : Form
    {
        public static string st1,st2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st1 = textBox1.Text;
            st2 = textBox2.Text;
            label30.Text = st1.Clone();
            int comp;

            comp = string.Compare(st1, st2);
            label31.Text = comp.ToString();

            label32.Text = String.Concat(st1, st2);

            string stt2 = "H";
            bool con = st1.Contains(stt2);
            string conb = con.ToString();
            label33.Text = conb;

            label34.Text = string.Copy(st1);

            string ss = "de";
            bool ew = st1.EndsWith(ss);
            label35.Text = ew.ToString();

            label36.Text = st1.GetHashCode().ToString();

            label37.Text = st1.GetType().ToString();

            label38.Text = st1.IndexOf("u").ToString();

            label39.Text = st1.Insert(6, "Haresh");

            bool ine = string.IsNullOrEmpty(st1);
            label40.Text = ine.ToString();

            bool isnw = string.IsNullOrWhiteSpace(st1);
            label41.Text = isnw.ToString();

            label42.Text = string.Join("har", st1);

            label43.Text = st1.LastIndexOf("h").ToString();

            char[] cc = { 'e', 'h' };
            label44.Text = st1.LastIndexOfAny(cc).ToString();

            label45.Text = st1.PadLeft(12);

            label46.Text = st1.PadRight(15);

            label47.Text = st1.Remove(3);

            label48.Text = st1.Replace("Ha", "A");

            bool sw = st1.StartsWith("H");
            label49.Text = sw.ToString();

            label50.Text = st1.Substring(4);

            label51.Text = st1.ToLower();

            label52.Text = st1.ToUpper();

            label53.Text = st1.Trim();

            label54.Text = st1.TrimEnd();

            label55.Text = st1.TrimStart();
        }
    }
}
