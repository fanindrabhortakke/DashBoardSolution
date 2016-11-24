using Dashboard.DatabaseRead;

namespace DashboardSolution.Models
{
	/// <summary>
	/// Database Connection Model
	/// </summary>
	public class DatabaseConnection : DashboardMetrics
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dashboardMetric">DashboardMetrics</param>
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