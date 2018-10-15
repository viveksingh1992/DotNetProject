using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class ProgramsPageObjects
    {
        public static IWebElement ProgramHeaderLink()
        {
            return WebDriverUtils.WaitForElementByCss("#navPrograms > span");
        }

        public static IWebElement ProgramLandingPageHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//div/section[1]/div/h2");
        }

        public static IWebElement ProgramSearchField()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(2) > div:nth-child(1) > input");
        }

        public static IWebElement RunSearch()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@class='btn']");
        }

        public static IWebElement SeachResultCount()
        {
            return WebDriverUtils.WaitForElementByCss("app-program-search-result > section > div > section > app-spinner > div > p");
        }

        public static IWebElement CreateNewProgramLink()
        {
            return WebDriverUtils.WaitForElementByCss("app-program-search-result > section > div > header > button > span");
        }

        public static IWebElement CreateNewProgramHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-create-program-index > section > div > h1");
        }

        public static IWebElement ProgramOverviewNavigation()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@href='/admin-programs/programs/14']");
        }

        public static IWebElement ProgramOverviewGenDetails()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-program-general-information/section/div/header/h4");
        }

        public static IWebElement ProgramOverviewEligibilityHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-program-eligibility-requirement/section/div/header/h4");
        }
    }
}
