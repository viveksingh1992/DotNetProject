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
    public class TransmittalTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void TransmittalNavigationTest()
        {
            try
            {
                TransmittalNavigation.TransmittalNavigationAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Finance.TransmittalHeaderText, WebDriverUtils.TextChecker(TransmittalPageObjects.FinanceLandingHeader()));
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
        public void TransmittalSearchTest()
        {
            try
            {
                SearchTransmittalAction.TransmittalSearchAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Finance.SearchResultsText, WebDriverUtils.TextChecker(TransmittalPageObjects.SearchResultsHeader()));
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
        public void TransmittalCreateTest()
        {
            try
            {
                CreateTransmittalAction.CreateTransmittal();
                Assert.AreEqual(TestEnvironment.LoadJson().Finance.CreateTransmittalHeaderText, WebDriverUtils.TextChecker(TransmittalPageObjects.CreateTransmittalHeader()));
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
		public void TransmittalOverviewNavigationTest()
		{
			try
			{
				TransmittalOverviewAction.TransmittalOverviewNavigation();
				Assert.AreEqual(TestEnvironment.LoadJson().Finance.TransmittalOverviewHeaderText, WebDriverUtils.TextChecker(TransmittalPageObjects.TransmittalOverviewHeaderText()));
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
		public void VoidTransmittalTest()
		{
			try
			{
				TransmittalOverviewAction.TransmittalOverviewNavigation();
				Assert.AreEqual(TestEnvironment.LoadJson().Finance.VoidTransmittalButtonText, WebDriverUtils.TextChecker(TransmittalPageObjects.VoidTransmittalButtonText()));
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
		public void RemoveTransmittalLinkTest()
		{
			try
			{
				TransmittalOverviewAction.TransmittalOverviewNavigation();
				Assert.AreEqual(TestEnvironment.LoadJson().Finance.RemoveLinkText, WebDriverUtils.TextChecker(TransmittalPageObjects.RemoveTransmittalLinkText()));
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