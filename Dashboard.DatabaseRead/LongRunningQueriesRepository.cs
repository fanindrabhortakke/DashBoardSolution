//-----------------------------------------------------------------------
// <copyright file="LongRunningQueriesRepository.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the LongRunningQueriesRepository class.</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Repository to get Long Running Queries
	/// </summary>
	public class LongRunningQueriesRepository : Repository<LongRunningQueriesMetrics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LongRunningQueriesRepository" /> class.
		/// Constructor
		/// </summary>
		/// <param name="connectionString">ConnecionString</param>
		public LongRunningQueriesRepository(string connectionString)
			: base(connectionString)
		{
		}

		/// <summary>
		/// Get Long Running queries
		/// </summary>
		public IEnumerable<LongRunningQueriesMetrics> GetLongRunningQueries
		{
			// DBAs across the country are having strokes 
			//  over this next command!
			get
			{
				using(var command = new SqlCommand(DBQueries.LongRunningTransactions))
				{
					return this.ExecuteQuery(command, System.Data.CommandType.Text);
				}
			}
		}

		/// <summary>
		/// Method for Long Running Queries metric
		/// </summary>
		/// <param name="sqlDataReader"> reader</param>
		/// <returns> Returns Populated Data</returns>
		public override LongRunningQueriesMetrics PopulateData(SqlDataReader sqlDataReader)
		{
			if(sqlDataReader == null)
			{
				throw new ArgumentNullException("sqlDataReader");
			}
			return new LongRunningQueriesMetrics
			{
				QueryText = sqlDataReader["statement_text"].ToString(),
				AverageElapsedTime = sqlDataReader["avg_elapsed_time"].ToString(),
				LastExecutionTime = sqlDataReader["last_execution_time"].ToString(),
				ExecutionCount = sqlDataReader["execution_count"].ToString()
			};
		}
	}
}
