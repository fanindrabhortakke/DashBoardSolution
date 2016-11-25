//-----------------------------------------------------------------------
// <copyright file="LongRunningQueriesMetrics.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the LongRunningQueriesMetrics class.</summary>
//-----------------------------------------------------------------------
namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// class LongRunningQueriesMetrics
	/// </summary>
	public class LongRunningQueriesMetrics
	{
		/// <summary>
		/// Get or Set QueryText
		/// </summary>
		/// <value>SQL Query Statement</value>
		public string QueryText { get; set; }
		/// <summary>
		/// Get or Set AverageElapsedTime
		/// </summary>
		/// <value>Average Elapsed Time</value>
		public string AverageElapsedTime { get; set; }
		/// <summary>
		/// Get or Set LastExecutionTime
		/// </summary>
		/// <value>Last Execution Time</value>
		public string LastExecutionTime { get; set; }

		/// <summary>
		/// Get or Set ExecutionCount
		/// </summary>
		/// <value>Execution Count of statement</value>
		public string ExecutionCount { get; set; }
	}
}
