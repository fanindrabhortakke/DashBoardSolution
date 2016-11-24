//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DashboardSolution
{
	/// <summary>
	/// MvcApplication Classs
	/// </summary>
	public class MvcApplication : System.Web.HttpApplication
	{
		/// <summary>
		/// Application Start Method
		/// </summary>
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
