using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DatabaseRead
{/// <summary>
/// Model  for DashBoard Metric
/// </summary>
	public class DashboardMetrics
	{
		/// <summary>
		/// Get or set Database Name
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Get or Set No Of Connections
		/// </summary>
		public string NoOfConnections { get; set; }

		/// <summary>
		/// Get or Set UserName
		/// </summary>
		public string UserName { get; set; }
	}
}
