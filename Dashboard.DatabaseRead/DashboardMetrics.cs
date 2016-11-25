//-----------------------------------------------------------------------
// <copyright file="DashboardMetrics.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the DashboardMetrics class.</summary>
//-----------------------------------------------------------------------

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Model  for DashBoard Metric
	/// </summary>
	public class DashboardMetrics
	{
		/// <summary>
		/// Get or set Database Name
		/// </summary>
		/// <value>Database Name</value>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Get or Set No Of Connections
		/// </summary>
		/// <value>Number of Connections</value>
		public string NoOfConnections { get; set; }

		/// <summary>
		/// Get or Set UserName
		/// </summary>
		/// <value>UserName of accessing sql server</value>
		public string UserName { get; set; }
	}
}
