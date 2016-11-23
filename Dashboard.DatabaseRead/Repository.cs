using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	public abstract class Repository<T> where T: class
	{
		private static SqlConnection _connection;

		public Repository(string connectionString)
		{
			_connection = new SqlConnection(connectionString);
		}

		public virtual T PopulateData(SqlDataReader reader)
		{
			return null;
		}

		/// <summary>
		/// Execute directly query
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		protected IEnumerable<T> GetRecords(SqlCommand command)
		{
			var list = new List<T>();
			command.Connection = _connection;
			_connection.Open();
			try
			{
				var reader = command.ExecuteReader();
				try
				{
					while(reader.Read())
					{
						list.Add(PopulateData(reader));
					}
				}
				finally
				{
					reader.Close();
				}
			}
			finally
			{
				_connection.Close();
			}
			return list;
		}

		/// <summary>
		/// Provide capability to execute Query, Stored procedure
		/// </summary>
		/// <param name="command"></param>
		/// <param name="commandType"></param>
		/// <returns></returns>
		protected IEnumerable<T> ExecuteQuery(SqlCommand command, CommandType commandType)
		{
			var list = new List<T>();
			command.Connection = _connection;
			command.CommandType = commandType;//CommandType.StoredProcedure;
			_connection.Open();
			try
			{
				var reader = command.ExecuteReader();
				try
				{
					while(reader.Read())
					{
						var record = PopulateData(reader);
						if(record != null)
						{ 
							list.Add(record);
						}
					}
				}
				finally
				{
					reader.Close();
				}
			}
			finally
			{
				_connection.Close();
			}
			return list;
		}

	}
}
