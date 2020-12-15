using DataBaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ScrumShot_CreateStory
{
    public partial class Stories : System.Web.UI.Page
    {
        string userID;
        string ProjectID;
        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["userID"].ToString();


            ProjectID = Request.QueryString["projectid"];

            ShowGreeting();
            showStories();
            ShowMembers();
        }

        private void ShowGreeting()
        {
            DataBase db = new DataBase();
            try
            {
                var dt = db.FillDataTable($"SELECT * FROM usersscrumshot WHERE Email = '{userID}'");

                lblGreeting.Text = "Hello " + dt.Rows[0]["FirstName"] + " " + dt.Rows[0]["Lastname"] + "!";

                dt = db.FillDataTable($"Select * FROM projectscrumshot Where ProjectID = {ProjectID}");

                lblProjectName.Text = "\"" + dt.Rows[0]["ProjectName"].ToString() + "\"";
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void showStories()
        {
            string ProjectID = Request.QueryString["projectid"];

            string user = $"Select * FROM storiesscrumshot Where ProjectID = {ProjectID}";
            DataBase db = new DataBase();
    
            try
            {
                var dt = db.FillDataTable(user);

                yourSories.InnerHtml = "<table class='yourStory'><thead><tr><th>Name</th><th>Status</th></tr></thead><tbody>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    yourSories.InnerHtml += $"<tr><td>{dt.Rows[i]["StoryDescribtion"]}</td>";
                    yourSories.InnerHtml += $"<td>{dt.Rows[i]["Storystatus"]}</td></tr>";

                }
                yourSories.InnerHtml += "</tbody></table>";
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                yourSories.InnerHtml = "<h2 color='red'>UPS SOMETHING WENT WRONG!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearCreateModeItems();
        }

        private void ClearCreateModeItems()
        {
            TxtBoxStory.Text = string.Empty;
            TxtBoxStoryPoints.Text = string.Empty;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string ProjectID = Request.QueryString["projectid"];
            string cmd = $"INSERT INTO storiesscrumshot (ProjectID,StoryDescribtion,Storystatus) VALUES ({ProjectID},'{TxtBoxStory.Text}','To Do');";
            DataBase db = new DataBase();

            try
            {
                db.ExecuteNonQuery(cmd);
                ClearCreateModeItems();
                showStories();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                yourSories.InnerHtml = "<h2 color='red'>UPS SOMETHING WENT WRONG!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void BtnReload_Click(object sender, EventArgs e)
        {
            ShowGreeting();
            showStories();
            ShowMembers();
        }

        protected void BtnRename_Click(object sender, EventArgs e)
        {
            string cmd = $"UPDATE projectscrumshot SET ProjectName = '{TxtBoxRename.Text}' WHERE ProjectID = {ProjectID}";
            DataBase db = new DataBase();

            try
            {
                db.ExecuteNonQuery(cmd);
                ShowGreeting();
                TxtBoxRename.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                yourSories.InnerHtml = "<h2 color='red'>COULDN´T RENAME PROJECT!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            try
            {
                db.ExecuteNonQuery($"DELETE FROM memebersinproject WHERE ProjectID = {ProjectID}");
                db.ExecuteNonQuery($"DELETE FROM projectscrumshot WHERE ProjectID = {ProjectID}");

                Response.Redirect("~/Project.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                yourSories.InnerHtml = "<h2 color='red'>COULDN´T DELETE PROJECT!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        public void ShowMembers()
        {
            string ProjectID = Request.QueryString["projectid"];

            string user = $"SELECT * FROM memebersinproject LEFT JOIN usersscrumshot ON memebersinproject.Email = usersscrumshot.Email WHERE ProjectID = {ProjectID}";
            DataBase db = new DataBase();

            try
            {
                var dt = db.FillDataTable(user);

                yourMembers.InnerHtml = "<table class='yourStory'><thead><tr><th>Name</th><th>e-Mail</th><th>Role</th></tr></thead><tbody>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    yourMembers.InnerHtml += $"<tr><td>{dt.Rows[i]["Firstname"]} {dt.Rows[i]["Lastname"]}</td>";
                    yourMembers.InnerHtml += $"<td>{dt.Rows[i]["Email"]}</td>";
                    yourMembers.InnerHtml += $"<td>{dt.Rows[i]["role"]}</td></tr>";
                }
                yourSories.InnerHtml += "</tbody></table>";
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                yourMembers.InnerHtml = "<h2 color='red'>UPS SOMETHING WENT WRONG!<h2>";
            }
            finally
            {
                db.Close();
            }
        }

        protected void BtnAddMember_Click(object sender, EventArgs e)
        {
            string cmd = $"INSERT INTO memebersinproject VALUE ('{txtBoxAddMember.Text}',{ProjectID},'{txtBoxMemberRole.Text}')";
            DataBase db = new DataBase();

            try
            {
                db.ExecuteNonQuery(cmd);
                ShowGreeting();
                txtBoxAddMember.Text = string.Empty;
                txtBoxMemberRole.Text = string.Empty;
                ShowMembers();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                yourMembers.InnerHtml = "<h2 color='red'>COULDN´T ADD Member!<h2>";
            }
            finally
            {
                db.Close();
            }
        }
    }
}