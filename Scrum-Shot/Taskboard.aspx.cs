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
    abstract class User
    {
        public User(int _userID, int _persID, string _firstname, string _lastname, string _email)
        {
            this.userID = _userID;
            this.persID = _persID;
            this.firstname = _firstname;
            this.lastname = _lastname;
            this.email = _email;
        }



        protected int userID { get;}
        protected int persID { get;}
        protected string firstname { get;}
        protected string lastname { get;}
        protected string email { get;}
        protected string password { get;}
        protected int priority { get; set; }
        protected List<Project> projects { get; set; }

        void AddProject(Project newProject)
        {
            projects.Add(newProject);
        }

    }
    class Admin : User
    {
        public Admin(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            this.priority = 0;
        }
    }
    class ScrumMaster : User
    {
        public ScrumMaster(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            priority = 1;
        }
    }
    class ProductOwner : User
    {
        public ProductOwner(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            priority = 2;
        }
    }
    class TeamMember : User
    {
        public TeamMember(int _userID, int _persID, string _firstname, string _lastname, string _email) : base(_userID, _persID, _firstname, _lastname, _email)
        {
            priority = 3;
        }
    }
    public class Project
    {
        int projectID;
        string projectName;

        public override string ToString()
        {
            return this.projectName.ToString();
        }

    }
}