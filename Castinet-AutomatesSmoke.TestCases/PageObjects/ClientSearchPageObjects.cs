using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class ClientSearchPageObjects
    {
        public static IWebElement LastNameField()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@placeholder='last name']");
        }

        public static IWebElement DobField()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@placeholder='mm/dd/yyyy']");
        }

        public static IWebElement RunSearchButton()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/section[2]/div[3]/button");
        }

        public static IWebElement ResultCountText()
        {
            return WebDriverUtils.WaitForElementByXpath("//section/app-spinner/div/p");
        }
    }
}
