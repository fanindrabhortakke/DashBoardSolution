using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	public class ConnectionManager
	{
		public static SqlConnection GetSqlConnection(string connectionString)
		{
			//string connectionString = ConfigurationManager.ConnectionStrings["DashboardApplicationConnectionString"].ConnectionString;
			var connection = new SqlConnection(connectionString);
			connection.Open();
			return connection;
		}
	}
}
