//-----------------------------------------------------------------------
// <copyright file="HomeController.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is Home Controller class.</summary>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Dashboard.DatabaseRead;
using DashboardSolution.Models;

namespace DashboardSolution.Controllers
{
	/// <summary>
	/// Home Controller
	/// </summary>
	public class HomeController : Controller
	{
		/// <summary>
		/// Connection String Variable
		/// </summary>
		private readonly string connectionString = string.Empty;
		/// <summary>
		/// Home Controller Constructor
		/// </summary>
		public HomeController() 
		{
			this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		}
		/// <summary>
		/// Main Action Method
		/// </summary>
		/// <returns></returns>
		public ActionResult Dashboard()
		{
			ApplicationMetricRepository applicationMetricRepository = new ApplicationMetricRepository(this.connectionString);
			IEnumerable<ApplicationMetric> applicationMetrices = applicationMetricRepository.GetAllApplications;
			ApplicationMetric applicationMetric = applicationMetrices.FirstOrDefault();

			DashboardMetricsRepository dashboardMetricsRepository = new DashboardMetricsRepository(applicationMetric.ConnectionString);
			IEnumerable<DashboardMetrics> dashboardInfoList = dashboardMetricsRepository.GetAllDashboardMetrics;

			LongRunningQueriesRepository longRunningQueriesRepository = new LongRunningQueriesRepository(applicationMetric.ConnectionString);
			IEnumerable<LongRunningQueriesMetrics> longRunningQueryList = longRunningQueriesRepository.GetLongRunningQueries;

			DashboardData dashboardData = new DashboardData();
			dashboardData.ApplicationName = applicationMetric.ApplicationName;
			
			foreach (var data in dashboardInfoList)
			{
				dashboardData.Connections.Add(new DatabaseConnection(data));
			}
			
			foreach (var data in longRunningQueryList)
			{
				dashboardData.RunningQueries.Add(new DatabaseQuery(data));
			}
			return this.View("Dashboard", dashboardData);
		}
	}
}