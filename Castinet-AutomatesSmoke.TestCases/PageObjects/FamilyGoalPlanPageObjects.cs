using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class FamilyGoalPlanPageObjects
    {
        public static IWebElement FamilyGoalPlanLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-left-nav/aside/nav/a[4]/span");
        }

        public static IWebElement FamilyGoalPlanHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household/app-index-family-goal-plans/h2");
        }

        public static IWebElement FamilyGoalCreatePlanLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household/app-index-family-goal-plans/a");
        }

        public static IWebElement FamilyGoalCreatePlanHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household/app-new-family-goal-plan/app-header/section/div/h1");
        }
    }
}
