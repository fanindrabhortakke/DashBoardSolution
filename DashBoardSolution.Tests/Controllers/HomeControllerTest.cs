using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DashboardSolution;
using DashboardSolution.Controllers;

namespace DashboardSolution.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
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
