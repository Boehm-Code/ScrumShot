using DataBaseClass;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace Scrum_Shot
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string username = txt_username.Text;

            DataBase db = new DataBase();

            string passwordFromDB = db.ExecuteScalar(
                $"SELECT Password FROM usersscrumshot WHERE Email = '{username}'"
                ).ToString().ToUpper();

            string passwordAsHash = GetSHA1(password);

            if (passwordAsHash == passwordFromDB) FormsAuthentication.RedirectFromLoginPage(username, false);
            else lbl_errorMessage.Text = "The username or the password are invalid.";
        }

        public static string GetSHA1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }

        protected void btnTestToRedirect_Click(object sender, EventArgs e)
        {
            if (Response.IsClientConnected)
            {
                Response.Redirect("ProductBacklog.aspx", false);
            }
            else
            {
                Response.End();
            }
        }
    }
}