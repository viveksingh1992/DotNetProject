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
    public class PartnerTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void PartnerNavigationTest()
        {
            try
            {
                PartnerAdmin.PartnerNavigation();
                Assert.AreEqual(TestEnvironment.LoadJson().Partners.LandingHeader, WebDriverUtils.TextChecker(PartnerPageObjects.PartnerLandPageHeader()));
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
        public void PartnerSearchTest()
        {
            try
            {
                PartnerAdminSearch.PartnerSearchAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Partners.PartnerResultHeader, WebDriverUtils.TextChecker(PartnerPageObjects.PartnerSearchResultHeader()));
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
        public void PartnerOverviewNavigationTest()
        {
            try
            {
                PartnerOverviewAction.PartnerOverviewNavigation();
                Assert.AreEqual(TestEnvironment.LoadJson().Partners.PartnerOverviewHeader, WebDriverUtils.TextChecker(PartnerPageObjects.PartnerOverviewHeader()));
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
        public void PartnerAddNewTest()
        {
            try
            {
                PartnerAdminCreateNew.CreateNewPartnerNavigation();
                Assert.AreEqual(TestEnvironment.LoadJson().Partners.CreatePartnerHeader, WebDriverUtils.TextChecker(PartnerPageObjects.CreatePartnerHeader()));
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
