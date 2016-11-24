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
		/// Constructor
		/// </summary>
		/// <param name="connectionString"></param>
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
					return ExecuteQuery(command, System.Data.CommandType.Text);
				}
			}
		}

		/// <summary>
		/// Method for Long Running Queries metric
		/// </summary>
		/// <param name="reader"> reader</param>
		/// <returns> Returns Populated Data</returns>
		public override LongRunningQueriesMetrics PopulateData(SqlDataReader reader)
		{
			if(reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			return new LongRunningQueriesMetrics
			{
				QueryText = reader["statement_text"].ToString(),
				AverageElapsedTime = reader["avg_elapsed_time"].ToString(),
				LastExecutionTime = reader["last_execution_time"].ToString(),
				ExecutionCount = reader["execution_count"].ToString()
			};
		}
	}
}
