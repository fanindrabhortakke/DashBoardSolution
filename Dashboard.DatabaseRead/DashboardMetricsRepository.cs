using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	public class DashboardMetricsRepository : Repository<DashboardMetrics>
	{
		public DashboardMetricsRepository(string connectionString)
            : base(connectionString)
        {
		}

		public IEnumerable<DashboardMetrics> GetAllDashboardMetrics()
		{
			// DBAs across the country are having strokes 
			//  over this next command!
			using(var command = new SqlCommand(DBQueries.UsersConnectedtoDatabase))
			{
				return ExecuteQuery(command,System.Data.CommandType.Text);
			}
		}

		public override DashboardMetrics PopulateData(SqlDataReader reader)
		{
			return new DashboardMetrics
			{
				DatabaseName = reader["DBName"].ToString(),
				NoOfConnections = reader["NumberOfConnections"].ToString(),
				UserName = reader["Loginame"].ToString()
			};
		}
	}
}
