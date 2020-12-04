using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scrum_Shot
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
    public abstract class User
    {
        public User(int _userID, int _persID, string _firstname, string _lastname, string _email)
        {
            this.UserID = _userID;
            this.PersID = _persID;
            this.Firstname = _firstname;
            this.Lastname = _lastname;
            this.Email = _email;
        }



        protected int UserID { get;}
        protected int PersID { get;}
        protected string Firstname { get;}
        protected string Lastname { get;}
        protected string Email { get;}
        protected string Password { get;}
        protected int Priority { get; set; }
        protected List<Project> Projects { get; }
        public void AddProject(Project newProject)
        {
            Projects.Add(newProject);
        }

    }
    public class Admin : User
    {
        public Admin(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID,_persID,_firstname,_lastname,_email)
        {
            this.Priority = 0;
        }
        
        public static void AddPersonToProject(Project project, User userToAdd)
        {
            project.Participants.Add(userToAdd);
            userToAdd.AddProject(project);
        }
    }
        
    public class ScrumMaster : User
    {
        public ScrumMaster(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            Priority = 1;
        }
    }
    public class ProductOwner : User
    {
        public ProductOwner(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            Priority = 2;
        }
    }
    public class TeamMember : User
    {
        public TeamMember(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            Priority = 3;
        }
    }
    public class Project
    {
        int projectID;
        string projectName;
        public List<User> participants = new List<User>();

        public override string ToString()
        {
            return this.projectName.ToString();
        }
        public int PropertyID { get; set; }
        public string ProjectName { get; set; }
        public List<User> Participants { get; }
    }
}