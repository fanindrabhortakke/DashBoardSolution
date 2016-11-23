using System.Collections.Generic;

namespace DashBoardSolution.Models
{
	public class DashboardData
	{
		public string ApplicationName { get; set; }
		public List<DatabaseConnection> Connections { get; set; }
		public List<DatabaseQuery> RunningQueries { get; set; }

		public DashboardData() 
		{
			RunningQueries = new List<DatabaseQuery>();
			Connections = new List<DatabaseConnection>();
		}
	}
}