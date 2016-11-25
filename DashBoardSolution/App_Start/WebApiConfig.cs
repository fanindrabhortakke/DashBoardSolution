//-----------------------------------------------------------------------
// <copyright file="WebApiConfig.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the WebApiConfig class.</summary>
//-----------------------------------------------------------------------
using System.Web.Http;

namespace DashboardSolution
{
	/// <summary>
	/// WebApiConfig Class
	/// </summary>
	public static class WebApiConfig
	{
		/// <summary>
		/// Method to Register API
		/// </summary>
		/// <param name="httpConfiguration">httpConfiguration</param>
		public static void Register(HttpConfiguration httpConfiguration)
		{
			if(httpConfiguration == null)
			{
				throw new System.ArgumentNullException("httpConfiguration");
			}

			httpConfiguration.MapHttpAttributeRoutes();

			httpConfiguration.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
