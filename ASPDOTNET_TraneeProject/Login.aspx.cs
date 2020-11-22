using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectTrials
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["UserName"];
            string PassWord = WebConfigurationManager.AppSettings["PassWord"];
            if(Username.Text == UserName && Password.Text == PassWord)
            {
                Session.Add("Username", UserName);
                Response.Redirect("Admin.aspx");
            }
            else
            {
                LabelMessage.Visible=true;
               // Response.Redirect("Login.aspx");
                
            }
            
        }
    
    }
}