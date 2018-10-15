using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
    [TestClass]
    public class HouseholdHistoryTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void HouseHoldOverviewNavigation()
        {
            try
            {
                HouseholdHistoryAction.HouseholdHistory();
                Assert.AreEqual(TestEnvironment.LoadJson().History.HistoryHeading, WebDriverUtils.TextChecker(HouseholdHistoryPageObjects.HistoryHeader()));
                Assert.AreEqual(TestEnvironment.LoadJson().History.ServiceHeading, WebDriverUtils.TextChecker(HouseholdHistoryPageObjects.ServiceHistoryHeader()));
                Assert.AreEqual(TestEnvironment.LoadJson().History.CasenoteHeading, WebDriverUtils.TextChecker(HouseholdHistoryPageObjects.CasenoteHistoryHeader()));
                Assert.AreEqual(TestEnvironment.LoadJson().History.GoalPlanHeading, WebDriverUtils.TextChecker(HouseholdHistoryPageObjects.FamilyGoalPlanHistoryHeader()));
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
