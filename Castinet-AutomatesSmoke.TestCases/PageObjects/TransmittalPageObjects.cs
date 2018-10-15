using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class TransmittalPageObjects
    {
        public static IWebElement FinanceTabLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@id='navFinance']");
        }
        public static IWebElement FinanceLandingHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//section/div/section[1]/div/h2");
        }

        public static IWebElement StartDateField()
        {
            return WebDriverUtils.WaitForElementByXpath("//input[@id='startDatePicker']");
        }

        public static IWebElement SearchTransmittalButton()
        {
            return WebDriverUtils.WaitForElementByXpath("//section/div/section[5]/div/button");
        }

        public static IWebElement SearchResultsHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//section/div/header/h4");
        }

        public static IWebElement CreateTransmittalButton()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-list-finance-transmittal/section/div[1]/header/button");
        }

        public static IWebElement CreateTransmittalHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//div/section[1]/div/h2");
        }

		public static IWebElement TransmittalOverviewNavigaterLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//mat-row[1]/mat-cell[1]/a");
		}

		public static IWebElement TransmittalOverviewHeaderText()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-read-finance-transmittal-overview/section/div/header/h4");
		}

		public static IWebElement VoidTransmittalButtonText()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-read-finance-transmittal-overview/section/div/header/button/span");
		}

		public static IWebElement RemoveTransmittalLinkText()
		{
			return WebDriverUtils.WaitForElementByXpath("//section[2]/mat-table/mat-row/mat-cell[5]/a");
		}
	}
}