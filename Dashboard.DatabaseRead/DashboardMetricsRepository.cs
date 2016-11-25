//-----------------------------------------------------------------------
// <copyright file="DashboardMetricsRepository.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the DashboardMetricsRepository class.</summary>
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
		/// Initializes a new instance of the <see cref="DashboardMetricsRepository" /> class.
		/// Constructor
		/// </summary>
		/// <param name="connectionString">Connection string of database</param>
		public DashboardMetricsRepository(string connectionString)
			: base(connectionString)
		{
		}

		/// <summary>
		/// Get All Dashboard Metrics
		/// </summary>
		/// <value>Get all dashboard metrics</value>
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
		/// <param name="sqlDataReader">sqlDataReader</param>
		/// <returns> It returns Populated Data</returns>
		public override DashboardMetrics PopulateData(SqlDataReader sqlDataReader)
		{
			if(sqlDataReader == null)
			{
				throw new ArgumentNullException("sqlDataReader");
			}
			return new DashboardMetrics
			{
				DatabaseName = sqlDataReader["DBName"].ToString(),
				NoOfConnections = sqlDataReader["NumberOfConnections"].ToString(),
				UserName = sqlDataReader["Loginame"].ToString()
			};
		}
	}
}
