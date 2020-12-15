using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Scrum_Shot
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


    protected void btn_signOut_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/Login.aspx");
    }
    }
    
    public class Project
    {
        public List<User> participants = new List<User>();

        public Project(string _projectName)
        {
            //ProjectID muss vergeben werden, da es ein primärschlüssel ist. Darf nicht vom User eingegeben werden!
            this.ProjectName = _projectName;
        }

        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public List<User> Participants { get; }
        
        public override string ToString()
        {
            return this.ProjectName.ToString();
        }
        public static void CreateProject(string projectName, ProductOwner productOwner)
        {
            //ist derjenige der ein Projekt erstellt der SCRUM-Master oder der Project-Owner? Oder kann auch ein User ein Projekt erstellen und den Scrum Master zuweisen=?
            Project newProject = new Project(projectName);
            productOwner.AddProject(newProject);
        }
    }

}