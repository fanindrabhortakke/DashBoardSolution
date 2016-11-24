using Dashboard.DatabaseRead;

namespace DashboardSolution.Models
{
	/// <summary>
	/// Database Query Model
	/// </summary>
	public class DatabaseQuery : LongRunningQueriesMetrics
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="longRunningQueriesMetrics">longRunningQueriesMetrics</param>
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