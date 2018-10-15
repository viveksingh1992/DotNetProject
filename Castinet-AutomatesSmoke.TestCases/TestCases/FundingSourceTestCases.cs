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
    public class FundingSourceTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void FundingSourceNavigationTest()
        {
            try
            {
                FundingSourceAdmin.FundingSourceNavigation();
                Assert.AreEqual(TestEnvironment.LoadJson().FundingSource.FundLandingHeader, WebDriverUtils.TextChecker(FundingSourcePageObjects.FundingSourceLandingHeader()));
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
        public void FundingSourceSearchTest()
        {
            try
            {
                FundingSourceAdminSearch.FundingSourceSearchTest();
                WebDriverUtils.HoldDriver();
                Assert.AreNotEqual(TestEnvironment.LoadJson().FundingSource.FundResultHeader, WebDriverUtils.TextChecker(FundingSourcePageObjects.FundingSourcResultHeader()));
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
        public void FundingSourceOverviewTest()
        {
            try
            {
                FundingSourceOverviewAction.FundingSourceOverviewNavigation();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().FundingSource.FunOverviewHeader, WebDriverUtils.TextChecker(FundingSourcePageObjects.FundingOverviewHeader()));
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
        public void FundingSourceCreateNewTest()
        {
            try
            {
                FundingSourceAdminCreateNew.FundingSourceAdminCreateNewAction();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().FundingSource.CreateNewHeader, WebDriverUtils.TextChecker(FundingSourcePageObjects.CreateFundHeader()));
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
