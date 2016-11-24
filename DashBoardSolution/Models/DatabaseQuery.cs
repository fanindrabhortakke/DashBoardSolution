//-----------------------------------------------------------------------
// <copyright  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
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
			this.QueryText = longRunningQueriesMetrics.QueryText;
			this.AverageElapsedTime = longRunningQueriesMetrics.AverageElapsedTime;
			this.LastExecutionTime = longRunningQueriesMetrics.LastExecutionTime;
			this.ExecutionCount = longRunningQueriesMetrics.ExecutionCount;
		}
	}
}