using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class PartnerPageObjects
    {
        public static IWebElement PartnerLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@href='/admin-programs/partners/search']");
        }

        public static IWebElement PartnerLandPageHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//section/section[1]/h2");
        }

        public static IWebElement PartnerSearchField()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(2) > div > section:nth-child(1) > input");
        }

        public static IWebElement SearchPartnerIncludeInactiveCheckbox()
        {
            return WebDriverUtils.WaitForElementByXpath("//mat-checkbox/label/div");
        }

        public static IWebElement PartnerSearchButton()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(2) > div > section:nth-child(6) > input");
        }

        public static IWebElement PartnerSearchResultHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-admin-programs-core > app-partner-search-results > h1");
        }

        public static IWebElement PartnerSearchResultVerification()
        {
            return WebDriverUtils.WaitForElementByCss("app-partner-search-results > div > header > div > span");
        }

        public static IWebElement ProgramDetailsLink()
        {
            return WebDriverUtils.WaitForElementByCss("mat-cell.mat-cell.cdk-column-name.mat-column-name.ng-star-inserted > span > a");
        }

        public static IWebElement PartnerOverviewHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-partner-overview-read/app-header/section/div/h1");
        }

        public static IWebElement AddPartnerLink()
        {
            return WebDriverUtils.WaitForElementByCss("app-partner-search-results > div > header > button");
        }

        public static IWebElement CreatePartnerHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-admin-programs-core > app-new-partner > h1");
        }
    }
}
