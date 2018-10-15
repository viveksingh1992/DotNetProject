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
    public class FamilyGoalPlanTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void FamilyGoalPlanTest()
        {
            try
            {
                FamiliGoalPlanActions.FamilyGoalPlan();
                Assert.AreEqual(TestEnvironment.LoadJson().FamilyGoalPlan.PlanHeading, WebDriverUtils.TextChecker(FamilyGoalPlanPageObjects.FamilyGoalPlanHeader()));
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
        public void FamilyGoalPlanCreateTest()
        {
            try
            {
                FamiliGoalPlanActions.FamilyGoalPlanCreate();
                Assert.AreEqual(TestEnvironment.LoadJson().FamilyGoalPlan.CreatePlanHeading, WebDriverUtils.TextChecker(FamilyGoalPlanPageObjects.FamilyGoalCreatePlanHeader()));
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
