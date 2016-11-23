using Dashboard.DatabaseRead;

namespace DashBoardSolution.Models
{
	public class DatabaseQuery : LongRunningQueriesMetrics
	{
		public DatabaseQuery(LongRunningQueriesMetrics longRunningQueriesMetrics)
		{
			QueryText = longRunningQueriesMetrics.QueryText;
			AverageElapsedTime = longRunningQueriesMetrics.AverageElapsedTime;
			LastExecutionTime = longRunningQueriesMetrics.LastExecutionTime;
			ExecutionCount = longRunningQueriesMetrics.ExecutionCount;
		}
	}
}