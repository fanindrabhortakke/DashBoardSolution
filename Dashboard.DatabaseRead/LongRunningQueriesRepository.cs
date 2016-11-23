using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	public class LongRunningQueriesRepository : Repository<LongRunningQueriesMetrics>
	{
		public LongRunningQueriesRepository(string connectionString)
			: base(connectionString)
		{
		}

		public IEnumerable<LongRunningQueriesMetrics> GetLongRunningQueries()
		{
			// DBAs across the country are having strokes 
			//  over this next command!
			using(var command = new SqlCommand(DBQueries.LongRunngTransactions))
			{
				return ExecuteQuery(command, System.Data.CommandType.Text);
			}
		}

		public override LongRunningQueriesMetrics PopulateData(SqlDataReader reader)
		{
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
