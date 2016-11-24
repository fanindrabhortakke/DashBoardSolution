//-----------------------------------------------------------------------
// <copyright file="Startup.cs"  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardSolution.Startup))]
namespace DashboardSolution
{
	/// <summary>
	/// Startup Class
	/// </summary>
	public partial class Startup
    { 
		/// <summary>
		/// Startup Class Configuration
		/// </summary>
		/// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
