//-----------------------------------------------------------------------
// <copyright file="DatabaseConnection.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
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
			this.DatabaseName = dashboardMetric.DatabaseName;
			this.NoOfConnections = dashboardMetric.NoOfConnections;
			this.UserName = dashboardMetric.UserName;
		}
	}
}