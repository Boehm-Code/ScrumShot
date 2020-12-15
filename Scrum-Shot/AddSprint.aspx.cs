using System;
using System.Collections.Generic;
using DataBaseClass;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scrum_Shot
{
    public partial class Sprintplanning : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

               
            }
        }

        protected void btn_AddSprint_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                int workhours = Convert.ToInt32(txt_Workhours.Text);
                DateTime startDate = Convert.ToDateTime(txt_StartDate.Text);
                DateTime endDate = Convert.ToDateTime(txt_EndDate.Text);
                lbl_Info.Text = "data ok";

            }
            

        }
    }
}