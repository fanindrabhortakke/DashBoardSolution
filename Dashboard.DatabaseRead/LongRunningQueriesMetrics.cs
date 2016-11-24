//-----------------------------------------------------------------------
// <copyright  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
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
		public string QueryText { get; set; }
		/// <summary>
		/// Get or Set AverageElapsedTime
		/// </summary>
		public string AverageElapsedTime { get; set; }
		/// <summary>
		/// Get or Set LastExecutionTime
		/// </summary>
		public string LastExecutionTime { get; set; }

		/// <summary>
		/// Get or Set ExecutionCount
		/// </summary>
		public string ExecutionCount { get; set; }
	}
}
