using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectTrials.App_Start;

namespace ProjectTrials
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"]!=null)
            {
                LogButton.Text = "Logout";
            }
            else
            {
                LogButton.Text = "Login";
            }
            LabelCounter.Text = "You are visitor No."+Application["Counter"].ToString();
            AllSettings Settings = (AllSettings)Application["Settings"];
            LabelHeader.Text = Settings.DefaultHeader;
            LabelInfo.Text = Settings.DefaultFooter;

        }

        protected void LogButton_Click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Session.Remove("Username");
                LogButton.Text = "Login";
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}