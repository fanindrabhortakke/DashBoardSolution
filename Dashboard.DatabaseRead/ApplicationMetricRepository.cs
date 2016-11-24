//-----------------------------------------------------------------------
// <copyright file="ApplicationMetricRepository.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the ApplicationMetricRepository class.</summary>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Repository for to get Application metric
	/// </summary>
	public class ApplicationMetricRepository : Repository<ApplicationMetric>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="connectionString"></param>
		public ApplicationMetricRepository(string connectionString)
			: base(connectionString)
		{
		}

		/// <summary>
		/// Gets all applications
		/// </summary>
		public IEnumerable<ApplicationMetric> GetAllApplications
		{
			get
			{
				using(var command = new SqlCommand(DBQueries.IncludedApplications))
				{
					return this.ExecuteQuery(command, System.Data.CommandType.Text);
				}
			}
		}

		/// <summary>
		/// Method to Populate Data
		/// </summary>
		/// <param name="reader">reader</param>
		/// <returns>returns populated data</returns>
		public override ApplicationMetric PopulateData(SqlDataReader reader)
		{
			if(reader == null)
			{
				throw new System.ArgumentNullException("reader");
			}

			return new ApplicationMetric
			{
				ApplicationName = reader["ApplicationName"].ToString(),
				ConnectionString = reader["ConnectionString"].ToString()
			};
		}
	}
}
