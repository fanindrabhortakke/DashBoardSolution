using Dashboard.DatabaseRead;

namespace DashBoardSolution.Models
{
	public class DatabaseConnection : DashboardMetrics
	{
		public DatabaseConnection(DashboardMetrics dashboardMetric)
		{
			DatabaseName = dashboardMetric.DatabaseName;
			NoOfConnections = dashboardMetric.NoOfConnections;
			UserName = dashboardMetric.UserName;
		}
	}
}