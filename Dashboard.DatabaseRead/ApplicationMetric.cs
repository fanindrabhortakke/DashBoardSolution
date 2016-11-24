//-----------------------------------------------------------------------
// <copyright file="ApplicationMetric.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
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
		public string ApplicationName { get; set; }
		/// <summary>
		/// Get or Set ConnectionString
		/// </summary>
		public string ConnectionString { get; set; }
	}
}
