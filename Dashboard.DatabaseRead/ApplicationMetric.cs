//-----------------------------------------------------------------------
// <copyright file="ApplicationMetric.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
// <summary>This is the ApplicationMetric class.</summary>
//-----------------------------------------------------------------------
namespace Dashboard.DatabaseRead
{
	/// <summary>
	/// Model to store ApplicationMetric
	/// </summary>
	public class ApplicationMetric
	{
		/// <summary>
		/// Get or Set Application Name
		/// </summary>
		/// <value>Application name</value>
		public string ApplicationName { get; set; }
		/// <summary>
		/// Get or Set ConnectionString
		/// </summary>
		/// <value>Connection string</value>
		public string ConnectionString { get; set; }
	}
}
