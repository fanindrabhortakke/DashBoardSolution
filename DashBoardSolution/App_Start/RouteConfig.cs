//-----------------------------------------------------------------------
// <copyright file="RouteConfig.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the RouteConfig class.</summary>
//-----------------------------------------------------------------------
using System.Web.Mvc;
using System.Web.Routing;

namespace DashboardSolution
{
	/// <summary>
	/// RouteConfiguration class
	/// </summary>
	public class RouteConfig
	{
		/// <summary>
		/// Method to Register Routes to default page
		/// </summary>
		/// <param name="routes"></param>
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Dashboard", id = UrlParameter.Optional }
			);
		}
	}
}
