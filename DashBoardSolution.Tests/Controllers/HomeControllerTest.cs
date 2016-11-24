//-----------------------------------------------------------------------
// <copyright  company="EPAM">
//     Copyright (c) EPAM INDIA. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Web.Mvc;
using DashboardSolution.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DashboardSolution.Tests.Controllers
{
	/// <summary>
	/// Home Controller TestClass
	/// </summary>
	[TestClass]
	public class HomeControllerTest
	{
		/// <summary>
		/// Method to Test Dashboard View
		/// </summary>
		[TestMethod]
		public void ShouldReturnIndexView()
		{
			// Arrange
			HomeController controller = new HomeController();

			//ACT
			var dashboardView = controller.Dashboard() as ViewResult;

			//ASSERT
			Assert.AreEqual("Dashboard", dashboardView.ViewName);

			controller.Dispose();
		}
	}
}
