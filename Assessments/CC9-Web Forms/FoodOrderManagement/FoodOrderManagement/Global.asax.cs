using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace FoodOrderManagement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["TotalVisitors"] = 0;
            Application["CurrentUsers"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();

            Application["TotalVisitors"] =
                Convert.ToInt32(Application["TotalVisitors"]) + 1;

            Application["CurrentUsers"] =
                Convert.ToInt32(Application["CurrentUsers"]) + 1;

            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application.Lock();

            Application["CurrentUsers"] =
                Convert.ToInt32(Application["CurrentUsers"]) - 1;

            Application.UnLock();
        }
    }
}