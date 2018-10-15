using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class IndividualOverviewPageObjects
    {
        public static IWebElement IndividualID()
        {
            return WebDriverUtils.WaitForElementByXpath("//mat-cell[5]/a");
        }

        public static IWebElement OverviewIdentifyingHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-client-overview/app-client-details/section/div/header/h4");
        }

        public static IWebElement IdentificationHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-client-overview/app-client-identifications/section/header/h4");
        }

        public static IWebElement OverviewDemographicHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-client-overview/app-client-demographics/section/div/header/h4");
        }

        public static IWebElement EditIdentifying()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-client-overview/app-client-details/section/div/header/button");
        }

        public static IWebElement IdentifyingHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-edit-client-identifying-information/div/div/h1");
        }

        public static IWebElement EditDemographic()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-client-overview/app-client-demographics/section/div/header/button");
        }

        public static IWebElement DemographicHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-client/app-edit-client-demographic-information/div/h1");
        }

		public static IWebElement EditIdentificationLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-client-identifications/section/header/button");
		}

		public static IWebElement RemoveLinkText()
		{
			return WebDriverUtils.WaitForElementByXpath("//div[1]/section/div/a");
		}

		public static IWebElement RemoveIdentificationLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-client-identifications/section/div/section/div/a");
		}
	}
}
