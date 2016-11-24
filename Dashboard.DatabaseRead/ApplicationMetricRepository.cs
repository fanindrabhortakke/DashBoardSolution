using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	public class ApplicationMetricRepository : Repository<ApplicationMetric>
	{
		public ApplicationMetricRepository(string connectionString)
			: base(connectionString)
		{
		}

		public IEnumerable<ApplicationMetric> GetAllApplications
		{
			get
			{
				using(var command = new SqlCommand(DBQueries.IncludedApplications))
				{
					return ExecuteQuery(command, System.Data.CommandType.Text);
				}
			}
		}

		public override ApplicationMetric PopulateData(SqlDataReader reader)
		{
			if(reader == null)
			{
				throw new System.ArgumentNullException("reader");
			}

			return new ApplicationMetric
			{
				ApplicationName = reader["ApplicationName"].ToString(),
				ConnectionString = reader["ConnectionString"].ToString()
			};
		}
	}
}
