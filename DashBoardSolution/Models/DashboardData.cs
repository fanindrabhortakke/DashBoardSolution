//-----------------------------------------------------------------------
// <copyright file="DashboardData.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is DashboardData class.</summary>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace DashboardSolution.Models
{
	/// <summary>
	/// Dashboard Data Model
	/// </summary>
	public class DashboardData
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DashboardData" /> class
		/// Constructor 
		/// </summary>
		public DashboardData()
		{
			this.Connections = new List<DatabaseConnection>();
			this.RunningQueries = new List<DatabaseQuery>();
		}

		/// <summary>
		/// Get Application Name
		/// </summary>
		/// <value>The name of the Application.</value>
		public string ApplicationName { get; set; }

		/// <summary>
		/// Get Connections
		/// </summary>
		/// <value>Returns Database Connection</value>
		public List<DatabaseConnection> Connections { get; }

		/// <summary>
		/// Get Running Queries
		/// </summary>
		/// <value>Returns Long Running Queries</value>
		public List<DatabaseQuery> RunningQueries { get; }
	}
}