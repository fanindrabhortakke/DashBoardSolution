using Dashboard.DatabaseRead;

namespace DashboardSolution.Models
{
	public class DatabaseQuery : LongRunningQueriesMetrics
	{
		public DatabaseQuery(LongRunningQueriesMetrics longRunningQueriesMetrics)
		{
			if(longRunningQueriesMetrics == null)
			{
				throw new System.ArgumentNullException("longRunningQueriesMetrics");
			}
			QueryText = longRunningQueriesMetrics.QueryText;
			AverageElapsedTime = longRunningQueriesMetrics.AverageElapsedTime;
			LastExecutionTime = longRunningQueriesMetrics.LastExecutionTime;
			ExecutionCount = longRunningQueriesMetrics.ExecutionCount;
		}
	}
}