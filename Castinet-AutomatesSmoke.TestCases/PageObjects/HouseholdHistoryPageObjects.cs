using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class HouseholdHistoryPageObjects
    {
        public static IWebElement HistoryLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-left-nav/aside/nav/a[2]/span");
        }

        public static IWebElement HistoryHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household-history-index/section[1]/div/h1");
        }

        public static IWebElement ServiceHistoryHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-household-service-history > section > header > h4");
        }

        public static IWebElement CasenoteHistoryHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-case-note-history > section > div > header > h4");
        }

        public static IWebElement FamilyGoalPlanHistoryHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-family-goal-plan-history > div > header > h4");
        }
    }
}
