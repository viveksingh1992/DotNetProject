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
    public class IndividualOverviewTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void IndividualOverviewNavigation()
        {
            try
            {
                IndividualOverviewAction.IndividualOverview();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.IdentifyingDetails, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.OverviewIdentifyingHeader()));
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.IdentificationDetails, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.IdentificationHeader()));
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.DemographicDetails, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.OverviewDemographicHeader()));
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
        public void EditIdentifyingNavigation()
        {
            try
            {
                IndividualOverviewAction.EditIdentifyingIo();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.IdentifyingHeading, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.IdentifyingHeader()));
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
        public void EditDemographicNavigation()
        {
            try
            {
                IndividualOverviewAction.EditDemographicIo();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.DemographicHeading, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.DemographicHeader()));
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
		public void EditIdentificationNavigation()
		{
			try
			{
				IndividualOverviewAction.EditIdentificationIo();
				WebDriverUtils.HoldDriver();
				Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.RemoveLinkText, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.RemoveLinkText()));
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
		public void RemoveIdentificationNavigation()
		{
			try
			{
				IndividualOverviewAction.RemoveIdentificationIo();
				WebDriverUtils.HoldDriver();
				Assert.AreEqual(TestEnvironment.LoadJson().HeadingIo.RemoveLinkText, WebDriverUtils.TextChecker(IndividualOverviewPageObjects.RemoveIdentificationLink()));
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
