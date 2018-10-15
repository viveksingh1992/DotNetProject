using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
    [TestClass]
    public class ProgramsServicesTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void ProgramsServicesTest()
        {
            try
            {
                ProgramsServicesAction.ProgramsServices();
                Assert.AreEqual(TestEnvironment.LoadJson().ProgramServices.PageHeading, WebDriverUtils.TextChecker(ProgramsServicesPageObjects.ProgramsServicesHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(LoginPageObjects.FailedMessage() + ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProgramsServicesReferOutTest()
        {
            try
            {
                ProgramsServicesAction.ProgramsServicesReferOut();
                Assert.AreEqual(TestEnvironment.LoadJson().ProgramServices.ReferOutHeading, WebDriverUtils.TextChecker(ProgramsServicesPageObjects.ProgramsServicesReferOutHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(LoginPageObjects.FailedMessage() + ex.Message);
                Assert.Fail(ex.Message);
            }
        }

		[TestMethod]
		public void ProgramsServicesFollowUpNavigationTest()
		{
			try
			{
				ProgramsServicesAction.FollowUpOverviewNavigation();
				Assert.AreEqual(TestEnvironment.LoadJson().ProgramServices.FollowUpHeader, WebDriverUtils.TextChecker(ProgramsServicesPageObjects.FollowUpHeader()));
				log.Info(System.Reflection.MethodBase.GetCurrentMethod());
				log.Info(LoginPageObjects.SuccessMessage());
			}
			catch (Exception ex)
			{

				log.Error(System.Reflection.MethodBase.GetCurrentMethod());
				log.Error(LoginPageObjects.FailedMessage() + ex.Message);
				Assert.Fail(ex.Message);
			}
		}

	}
}
