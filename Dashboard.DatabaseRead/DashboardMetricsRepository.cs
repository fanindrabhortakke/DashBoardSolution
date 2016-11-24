//-----------------------------------------------------------------------
// <copyright file="DashboardMetricsRepository.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Repository for Dashboard Metrics
	/// </summary>
	public class DashboardMetricsRepository : Repository<DashboardMetrics>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="connectionString"></param>
		public DashboardMetricsRepository(string connectionString)
			: base(connectionString)
		{
		}

		/// <summary>
		/// Get All Dashboard Metrics
		/// </summary>
		public IEnumerable<DashboardMetrics> GetAllDashboardMetrics
		{
			get
			{
				// DBAs across the country are having strokes 
				//  over this next command!
				using(var command = new SqlCommand(DBQueries.UsersConnectedToDatabase))
				{
					return this.ExecuteQuery(command, System.Data.CommandType.Text);
				}
			}
		}

		/// <summary>
		/// Method for Populating Data
		/// </summary>
		/// <param name="reader">reader</param>
		/// <returns></returns>
		public override DashboardMetrics PopulateData(SqlDataReader reader)
		{
			if(reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			return new DashboardMetrics
			{
				DatabaseName = reader["DBName"].ToString(),
				NoOfConnections = reader["NumberOfConnections"].ToString(),
				UserName = reader["Loginame"].ToString()
			};
		}
	}
}
