namespace Dashboard.DatabaseRead
{
	public class LongRunningQueriesMetrics
	{
		public string QueryText { get; set; }
		public string AverageElapsedTime { get; set; }
		public string LastExecutionTime { get; set; }
		public string ExecutionCount { get; set; }
	}
}
