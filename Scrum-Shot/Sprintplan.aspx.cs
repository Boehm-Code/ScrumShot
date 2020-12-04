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
    public partial class Sprintplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                string sql = "SELECT dept_id,dept_desc FROM departments";
                DataBase db = new DataBase();
                TestConnect();
                DataTable dt = db.FillDataTable(sql);
                GridView1 = dt;
                rblDepts.DataSource = dt;
                rblDepts.DataValueField = "dept_id";
                rblDepts.DataTextField = "dept_desc";
                this.DataBind();
                rblDepts.SelectedIndex = 0;
            }
        }

        protected void TestConnect()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["AppDbFromExt"].ConnectionString;

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                lblInfo.Text = $"Connected To = {connection.DataSource} state = {connection.State}";
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string user = $"INSERT INTO mailing_list VALUES('{TextBoxEmail.Text}', '{TextBoxLastName.Text}', '{TextBoxFirstName.Text}', {TextBoxGraduation.Text}, '{rblDepts.SelectedValue}');";
                DataBase db = new DataBase();
                db.ExecuteNonQuery(user);

                DataTable dt = db.FillDataTable("SELECT * FROM mailing_list");
                lblInfo.Text = dt.Rows.Count.ToString() + "Einträge vorhanden!";
                db.Close();
            }
        }
        protected void btn_AddSprint_Click(object sender, EventArgs e)
        {

        }
    }
}
}