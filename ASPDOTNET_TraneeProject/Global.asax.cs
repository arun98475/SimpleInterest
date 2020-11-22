using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using ProjectTrials.App_Start;

namespace ProjectTrials
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Add("Key", "1234");
            string Key = (string)Application["Key"];
            AllSettings Settings = AllManager.LoadSettings();
            Application.Add("Settings", Settings);
        }
        void Session_Start(object sender, EventArgs e)
        {
            if (Application["Counter"] == null)
            {
                Session.Add("Counter", 0);
            }
            int iCounter = Convert.ToInt32(Application["Counter"]);
            iCounter++;
            AllSettings sett = (AllSettings)Application["Settings"];
            sett.VisitorNumber += iCounter;
            AllManager.SaveSettings(sett);
            Application["Counter"] = sett.VisitorNumber.ToString();



        }
    }
}