using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Base Repository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class Repository<T> where T : class
	{
		/// <summary>
		/// connection object
		/// </summary>
		private static SqlConnection connection;
		/// <summary>
		/// Repository Constructor
		/// </summary>
		/// <param name="connectionString">connectionSTring</param>
		protected Repository(string connectionString)
		{
			connection = new SqlConnection(connectionString);
		}
		/// <summary>
		/// Fetch Data Method
		/// </summary>
		/// <param name="reader">SQL Data Reader</param>
		/// <returns>Null</returns>
		public virtual T PopulateData(SqlDataReader reader)
		{
			return null;
		}

		/// <summary>
		/// Execute directly query
		/// </summary>
		/// <param name="command">SQL Command</param>
		/// <returns>Result List</returns>
		protected IEnumerable<T> GetRecords(SqlCommand command)
		{
			if(command == null)
			{
				throw new ArgumentNullException("command");
			}

			var list = new List<T>();
			command.Connection = connection;
			connection.Open();
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
				connection.Close();
			}
			return list;
		}

		/// <summary>
		/// Provide capability to execute Query, Stored procedure
		/// </summary>
		/// <param name="command"></param>
		/// <param name="commandType"></param>
		/// <returns>Result List</returns>
		protected IEnumerable<T> ExecuteQuery(SqlCommand command, CommandType commandType)
		{
			if(command == null)
			{
				throw new ArgumentNullException("command");
			}

			var list = new List<T>();
			command.Connection = connection;
			command.CommandType = commandType;
			connection.Open();
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
				connection.Close();
			}
			return list;
		}

	}
}
