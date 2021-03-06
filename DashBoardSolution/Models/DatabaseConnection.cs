﻿//-----------------------------------------------------------------------
// <copyright file="DatabaseConnection.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is DatabaseConnection class.</summary>
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
		/// Initializes a new instance of the <see cref="DatabaseConnection" /> class.
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