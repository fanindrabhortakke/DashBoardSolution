//-----------------------------------------------------------------------
// <copyright  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// DB Queries
	/// </summary>
	public static class DBQueries
	{
		/// <summary>
		/// Queries to read from Database to get connected users
		/// </summary>
		public const string UsersConnectedToDatabase = "SELECT DB_NAME(dbid) AS DBName, COUNT(dbid) AS NumberOfConnections,loginame FROM sys.sysprocesses GROUP BY dbid, loginame ORDER BY DB_NAME(dbid)";

		/// <summary>
		/// Queries to read from Database to get LongRunningTransactions
		/// </summary>
		public const string LongRunningTransactions = "SELECT TOP 10 creation_time ,last_execution_time ,total_physical_reads ,total_logical_reads, total_logical_writes , execution_count, total_worker_time, total_elapsed_time, total_elapsed_time / execution_count avg_elapsed_time,SUBSTRING(st.text, (qs.statement_start_offset/2) + 1, ((CASE statement_end_offset  WHEN -1 THEN DATALENGTH(st.text)  ELSE qs.statement_end_offset END - qs.statement_start_offset)/2) + 1) AS statement_text FROM sys.dm_exec_query_stats AS qs CROSS APPLY sys.dm_exec_sql_text(qs.sql_handle) st ORDER BY total_elapsed_time / execution_count DESC";
		/// <summary>
		/// Queries to read from Database to get IncludedApplications
		/// </summary>
		public const string IncludedApplications = "Select ApplicationName,ConnectionString from DashboardApplication";
	}
}
