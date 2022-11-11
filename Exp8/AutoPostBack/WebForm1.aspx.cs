using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exp_8auto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1 != null)
            {
                Label7.Text = "you selected "+RadioButtonList1.SelectedItem.ToString();
            }
            else
            {
                Label7.Text = "Select item from list";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label6.Text = "you Entered " + TextBox1.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Label5.Text = "you entered "+ TextBox2.Text;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chkSelect = "";
            for(int i=0;i<CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    if (chkSelect == "")
                    {
                        chkSelect=CheckBoxList1.Items[i].Text;
                    }
                    else
                    {
                        chkSelect += "," + chkSelect;
                    }
                    TextBox3.Text=chkSelect;
                }
                else if (chkSelect == "")
                {
                    TextBox3.Text = "";
                }
            }
            //Label8.Text = "You selected " + CheckBoxList1.SelectedItem.ToString();
           // Label9.Text = "" + CheckBoxList1.SelectedItem.ToString();
        }
    }
}