using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
    [TestClass]
    public class ProgramTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void ProgramsNavigationTest()
        {
            try
            {
                ProgramAdmin.ProgramsNavigation();
                Assert.AreEqual(TestEnvironment.LoadJson().Programs.HeaderFirst, WebDriverUtils.TextChecker(ProgramsPageObjects.ProgramLandingPageHeader()));
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
        public void ProgramsSearchTest()
        {
            try
            {
                ProgramsSearchAction.ProgramSearchAction();
                WebDriverUtils.HoldDriver();
                Assert.AreNotEqual(TestEnvironment.LoadJson().Programs.ResultCount, WebDriverUtils.TextChecker(ProgramsPageObjects.SeachResultCount()));
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
        public void ProgramsCreateNewTest()
        {
            try
            {
                ProgramAdminCreateNew.CreateNewAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Programs.CreateNewHeader, WebDriverUtils.TextChecker(ProgramsPageObjects.CreateNewProgramHeader()));
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
        public void ProgramsOverviewNavigationTest()
        {
            try
            {
                ProgramOverview.ProgramOverviewNavigation();
                WebDriverUtils.HoldDriver();
                Assert.AreEqual(TestEnvironment.LoadJson().Programs.ProgramOverviewGenDetails, WebDriverUtils.TextChecker(ProgramsPageObjects.ProgramOverviewGenDetails()));
                Assert.AreEqual(TestEnvironment.LoadJson().Programs.ProgramOverviewEligReq, WebDriverUtils.TextChecker(ProgramsPageObjects.ProgramOverviewEligibilityHeader()));
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
