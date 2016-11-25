﻿//-----------------------------------------------------------------------
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
		/// Get Application Name
		/// </summary>
		public string ApplicationName { get; set; }

		/// <summary>
		/// Get Connections
		/// </summary>
		public List<DatabaseConnection> Connections { get; }

		/// <summary>
		/// Get Running Queries
		/// </summary>
		public List<DatabaseQuery> RunningQueries { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DashboardData" /> class
		/// Constructor 
		/// </summary>
		public DashboardData()
		{
			this.RunningQueries = new List<DatabaseQuery>();
			this.Connections = new List<DatabaseConnection>();
		}
	}
}