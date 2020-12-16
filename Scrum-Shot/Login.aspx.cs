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
            if (Page.IsValid)
            {
                string password = txt_password.Text;
                string email = txt_email.Text;
                try
                {
                    DataBase db = new DataBase();
                    string passwordFromDB = db.ExecuteScalar(
                           $"SELECT password FROM usersscrumshot WHERE email = '{email}'"
                           ).ToString().ToUpper();

                    string passwordAsHash = GetSHA1(password);

                    FormsAuthentication.Initialize();

                    if (passwordAsHash == passwordFromDB) FormsAuthentication.RedirectFromLoginPage(email, false);
                    else throw new Exception("Password is invalid.");
                }
                catch (Exception ex)
                {
                    lbl_errorMessage.Text = "Info: The username or the password are invalid.";
                }
            }
        }

        public static string GetSHA1(string value)  //https://stackoverflow.com/questions/13527277/drop-in-replacement-for-formsauthentication-hashpasswordforstoringinconfigfile
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
    }
}