﻿//-----------------------------------------------------------------------
// <copyright  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
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
		/// <param name="config">config</param>
		public static void Register(HttpConfiguration config)
		{

			if(config == null)
			{
				throw new System.ArgumentNullException("config");
			}

		
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
