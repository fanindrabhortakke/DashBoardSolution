//-----------------------------------------------------------------------
// <copyright file="DatabaseQuery.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is DatabaseQuery class.</summary>
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
		/// Initializes a new instance of the <see cref="DatabaseQuery" /> class.
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