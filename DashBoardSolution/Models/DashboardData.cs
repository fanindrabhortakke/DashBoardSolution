using System.Collections.Generic;

namespace DashboardSolution.Models
{
	/// <summary>
	/// Dashboard Data Model
	/// </summary>
	public class DashboardData
	{
		/// <summary>
		/// Get Application Name
		/// </summary>
		public string ApplicationName { get; set; }

		/// <summary>
		/// Get Connections
		/// </summary>
		public List<DatabaseConnection> Connections { get; }

		/// <summary>
		/// Get Running Queries
		/// </summary>
		public List<DatabaseQuery> RunningQueries { get; }

		/// <summary>
		/// Constructor 
		/// </summary>
		public DashboardData()
		{
			RunningQueries = new List<DatabaseQuery>();
			Connections = new List<DatabaseConnection>();
		}
	}
}