using Dashboard.DatabaseRead;
using DashboardSolution.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardSolution.Controllers
{
	public class HomeController : Controller
	{
		readonly string ConnectionString = string.Empty;
		public HomeController() 
		{
			ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		}
		public ActionResult Dashboard()
		{
			ApplicationMetricRepository applicationMetricRepository = new ApplicationMetricRepository(ConnectionString);
			IEnumerable<ApplicationMetric> applicationMetrices = applicationMetricRepository.GetAllApplications;
			ApplicationMetric applicationMetric = applicationMetrices.FirstOrDefault();

			DashboardMetricsRepository dashboardMetricsRepository = new DashboardMetricsRepository(applicationMetric.ConnectionString);
			IEnumerable<DashboardMetrics> dashboardInfoList = dashboardMetricsRepository.GetAllDashboardMetrics;

			LongRunningQueriesRepository longRunningQueriesRepository = new LongRunningQueriesRepository(applicationMetric.ConnectionString);
			IEnumerable<LongRunningQueriesMetrics> longRunningQueryList = longRunningQueriesRepository.GetLongRunningQueries;

			DashboardData dashboardData = new DashboardData();
			dashboardData.ApplicationName = applicationMetric.ApplicationName;
			
			foreach (var data in dashboardInfoList) {
				dashboardData.Connections.Add(new DatabaseConnection(data));
			}
			
			foreach (var data in longRunningQueryList)
			{
				dashboardData.RunningQueries.Add(new DatabaseQuery(data));
			}
			return View("Dashboard", dashboardData);
		}
	}
}