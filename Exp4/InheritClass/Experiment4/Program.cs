using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment4
{
    interface Student
    {
        int GetData(string enroll, int std);
    }
    interface Marks
    {
        string GetMarks(int m1, int m2, int m3, int m4, int m5);
    }
    public class Results : Student, Marks
    {
        public static int enroll_no;
        public static int  standard;
        public static int s1, s2, s3, s4, s5, Sum;

        public int GetData(string enroll, int std)
        {
            enroll_no = int.Parse(enroll);
            standard = std;
            return enroll_no & standard;
        }

        public string GetMarks(int m1, int m2, int m3, int m4, int m5)
        {
            Sum = m1 + m2 + m3 + m4 + m5;
            return Sum.ToString();
        }

        public string percent()
        {
            double per = (Sum * 100) / 500;
            return per.ToString();
        }
        internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }       
        }
    }
}
