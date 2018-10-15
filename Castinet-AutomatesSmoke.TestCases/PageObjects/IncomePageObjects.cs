using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class IncomePageObjects
    {
        public static IWebElement AddIncomeLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-income-profile-list/section/div/header/button");
        }

        public static IWebElement AddIncomeHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-new-income-profile/app-create-income-profile/section[1]/div/h1");
        }
    }
}
