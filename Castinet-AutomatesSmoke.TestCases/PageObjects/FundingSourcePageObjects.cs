using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class FundingSourcePageObjects
    {
        public static IWebElement FundingSourceLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@href='/admin-programs/funding']");
        }

        public static IWebElement FundingSourceLandingHeader()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(1) > div > h2");
        }

        public static IWebElement SearchFundingSourceField()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(2) > div.form__group.-flexWidth30 > input");
        }

        public static IWebElement FundingSourceRunSearch()
        {
            return WebDriverUtils.WaitForElementByCss("section:nth-child(2) > div.form__group.-button > button");
        }

        public static IWebElement FundingSourcResultHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-funding-source-search-result > div > header > div > span");
        }

        public static IWebElement FundingOverviewLink()
        {
            return WebDriverUtils.WaitForElementByCss("mat-cell.mat-cell.cdk-column-name.mat-column-name.ng-star-inserted > span > a");
        }

        public static IWebElement FundingOverviewHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//h1");
        }

        public static IWebElement CreateFundingSource()
        {
            return WebDriverUtils.WaitForElementByCss("app-funding-source-search-result > div > header > button");
        }

        public static IWebElement CreateFundHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//h1");
        }
    }
}
