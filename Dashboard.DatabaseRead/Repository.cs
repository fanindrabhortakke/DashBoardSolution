//-----------------------------------------------------------------------
// <copyright file="Repository.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the Repository class.</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Base Repository
	/// </summary>
	/// <typeparam name="T"> Type of Model</typeparam>
	public abstract class Repository<T> where T : class
	{
		/// <summary>
		/// connection object
		/// </summary>
		private static SqlConnection connection;
		/// <summary>
		/// Initializes a new instance of the <see cref="Repository{T}"/> class.
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
		/// <param name="sqlCommand">SqlCommand Parameter</param>
		/// <param name="commandType">commandType Parameter</param>
		/// <returns>Result List</returns>
		protected IEnumerable<T> ExecuteQuery(SqlCommand sqlCommand, CommandType commandType)
		{
			if(sqlCommand == null)
			{
				throw new ArgumentNullException("sqlCommand");
			}

			var list = new List<T>();
			sqlCommand.Connection = connection;
			sqlCommand.CommandType = commandType;
			connection.Open();
			try
			{
				var reader = sqlCommand.ExecuteReader();
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
