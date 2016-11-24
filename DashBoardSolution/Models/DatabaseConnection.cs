using Dashboard.DatabaseRead;

namespace DashBoardSolution.Models
{
	public class DatabaseConnection : DashboardMetrics
	{
		public DatabaseConnection(DashboardMetrics dashboardMetric)
		{
			if(dashboardMetric == null)
			{
				throw new System.ArgumentNullException("dashboardMetric");
			}
			DatabaseName = dashboardMetric.DatabaseName;
			NoOfConnections = dashboardMetric.NoOfConnections;
			UserName = dashboardMetric.UserName;
		}
	}
}