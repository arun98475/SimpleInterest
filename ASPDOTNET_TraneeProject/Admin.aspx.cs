using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectTrials.App_Start;

namespace ProjectTrials
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Username"] == null)
            {
               
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    AllSettings Settings = (AllSettings)Application["Settings"];
                    Text1.Text = Settings.DefaultText1;
                    Text2.Text = Settings.DefaultText2;
                    HeaderText.Text = Settings.DefaultHeader;
                    FooterText.Text = Settings.DefaultFooter;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            AllSettings Setting = (AllSettings)Application["Settings"];
            Setting.DefaultText1= Text1.Text;
             Setting.DefaultText2= Text2.Text;
             Setting.DefaultHeader= HeaderText.Text;
             Setting.DefaultFooter= FooterText.Text;
            AllManager.SaveSettings(Setting);
            Application["Settings"] = Setting;
            Response.Redirect("Default.aspx");
        }
    }
}