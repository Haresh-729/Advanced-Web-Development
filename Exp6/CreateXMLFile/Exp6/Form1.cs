using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Created");
            
            DataSet Ds = new DataSet();
            Ds.DataSetName = "Marksheet";
            DataTable Dt = new DataTable();
            Dt.TableName = "Computer";
            DataColumn Dc1 = new DataColumn("ID");
            DataColumn Dc2 = new DataColumn("Name");
            DataColumn Dc3 = new DataColumn("Marks Obtained");
            DataColumn Dc4 = new DataColumn("Outof Marks");
            DataColumn Dc5 = new DataColumn("Percentage");
            DataColumn Dc6 = new DataColumn("Class");
            Dt.Columns.AddRange(new DataColumn[] { Dc1, Dc2, Dc3, Dc4, Dc5, Dc6 });
            Dt.Rows.Add("01", "Haresh", "589", "600", "90", "First Class");
            Dt.Rows.Add("02", "Ravindra", "560", "600", "70", "Second Class");
            Dt.Rows.Add("03", "Shyam", "440", "600", "80", "Third Class");
            Dt.Rows.Add("04", "Amit", "489", "600", "77", "Second Class");
            Ds.Tables.Add(Dt);
            Ds.WriteXml("Marksheet.xml");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                DataSet D1 = new DataSet();
                D1.ReadXml("Marksheet.xml");
                dataGridView1.DataSource = D1.Tables[0];
            }
            catch {
                MessageBox.Show("Data not entered");
            }
            
        }
    }
}
