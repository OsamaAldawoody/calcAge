using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calcAge
{
    public partial class input : System.Web.UI.Page
    {



        string day;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                //add year to dropdown list 
                ddlYear.Items.Add("year");
                for (int i = 1985; i <= 2016; i++)
                {
                    ddlYear.Items.Add(i.ToString());
                }
                //add month to dropdown list
                ddlMonth.Items.Add("month");
                for (int i = 1; i <= 12; i++)
                {
                    ddlMonth.Items.Add(i.ToString());
                }
               
            }
            ddlDay.Items.Clear();
                //add day to dropdown list 
                int day;
                if (ddlMonth.SelectedItem.ToString() == "2")
                {
                    day = 28;
                }
                else if (ddlMonth.SelectedItem.ToString() == "3" || ddlMonth.SelectedItem.ToString() == "5")
                {
                    day = 31;
                }
                else
                {
                    day = 30;
                }
                ddlDay.Items.Add("day");
                for (int i = 1; i <= day; i++)
                {
                    ddlDay.Items.Add(i.ToString());
                }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            
            Response.Redirect("output.aspx?name=" + txtName.Text +
                "&year=" + ddlYear.Text + "&month=" + ddlMonth.Text + "&day=" + ddlDay.Text);
            
        }

        protected void ddlDay_TextChanged(object sender, EventArgs e)
        {
            day = ddlDay.Text;
        }
    }
   
}