using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calcAge
{
    public partial class output : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int day = int.Parse(Request.QueryString["day"]);
            if (currentDay < day)
            {
                currentDay += 30;
                currentMonth -= 1;
            }
            int dayAge = currentDay - day;
            int month = int.Parse(Request.QueryString["month"]);
            if (currentMonth < month)
            {
                currentMonth += 12;
                currentYear -= 1;
            }
            int monthAge = currentMonth - month;
            int year = int.Parse(Request.QueryString["year"]);
            int yearAge = currentYear - year;
            lblName.Text += Request.QueryString["name"].ToString();
            lblAge.Text += string.Format("{0} years , {1}month , {2}day",yearAge,monthAge,dayAge);
        }

    }
}