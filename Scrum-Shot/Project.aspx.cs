using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Odbc;
using DataBaseClass;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Scrum_Shot
{
    public partial class Project : System.Web.UI.Page
    {
        string userID;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userID"] = "AOUS";

            userID = Session["userID"].ToString();

            showProjects();
        }

        protected void ConnectToServer()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["AppDbFromExt"].ConnectionString;

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
            }
        }

        private void CreateProject()
        {
            string user = $"INSERT INTO projectscrumshot (ProjectName) VALUES ('{TxtBoxProjectName.Text}')";
            DataBase db = new DataBase();

            try
            {
                db.ExecuteNonQuery(user);
                var dt = db.FillDataTable($"SELECT ProjectID FROM projectscrumshot WHERE ProjectName = '{TxtBoxProjectName.Text}'");
                string projectid = dt.Rows[0]["ProjectID"].ToString();

                db.ExecuteNonQuery($"INSERT INTO memebersinproject VALUES ('{userID}',{projectid},'ADMIN')");
                TxtBoxProjectName.Text = string.Empty;
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message); ;
                myProjects.InnerHtml = "<h2 color='red'>UPS SOMETHING WENT WRONG!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void btnCreateProject_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CreateProject();
                BtnReload_Click(sender,e);
            }

        }

        private void showProjects()
        {
            string user = $"SELECT * FROM projectscrumshot LEFT JOIN memebersinproject ON projectscrumshot.ProjectID = memebersinproject.ProjectID WHERE memebersinproject.Email = '{userID}' AND memebersinproject.Role = 'ADMIN'";
            DataBase db = new DataBase();

            try
            {
                var dt = db.FillDataTable(user);

                myProjects.InnerHtml = "<table class='myProjectTable'><thead><tr><th>Name</th><th>Stories</th><th>Members</th></tr></thead><tbody>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    myProjects.InnerHtml += $"<tr><td>{dt.Rows[i]["ProjectName"]}</td>";
                    myProjects.InnerHtml += $"<td>{db.ExecuteScalar($"SELECT COUNT(StoryID) FROM storiesscrumshot WHERE ProjectID = {dt.Rows[i]["ProjectID"]}")} </td>";
                    myProjects.InnerHtml += $"<td>{db.ExecuteScalar($"SELECT COUNT(Email) FROM memebersinproject WHERE ProjectID = {dt.Rows[i]["ProjectID"]}")}</td>";
                    myProjects.InnerHtml += $"<td id='buttonEdit'><a href='/stories.aspx?projectid={dt.Rows[i]["ProjectID"]}'>edit</a></td></tr>";    //per URL ProjectID mitgeben
                }
                myProjects.InnerHtml += "</tbody></table>";
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                myProjects.InnerHtml = "<h2 color='red'>UPS SOMETHING WENT WRONG!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void BtnReload_Click(object sender, EventArgs e)
        {
            showProjects();
        }
    }
}