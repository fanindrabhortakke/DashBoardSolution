using System.Collections.Generic;

namespace DashboardSolution.Models
{
	public class DashboardData
	{
		public string ApplicationName { get; set; }
		public List<DatabaseConnection> Connections { get; }
		public List<DatabaseQuery> RunningQueries { get; }

		public DashboardData() 
		{
			RunningQueries = new List<DatabaseQuery>();
			Connections = new List<DatabaseConnection>();
		}
	}
}