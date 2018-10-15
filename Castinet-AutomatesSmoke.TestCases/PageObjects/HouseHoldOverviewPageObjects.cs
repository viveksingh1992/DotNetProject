using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class HouseHoldOverviewPageObjects
    {
        public static IWebElement ClientName()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/div/mat-table/mat-row/mat-cell[1]/a");
        }

        public static IWebElement HoHeading()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-header/section/div/h1");
        }

        public static IWebElement EditAddressLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-physical-address-read/section/div/header/button/i");
        }

        public static IWebElement EditAddressHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-household/app-edit-client-contact-information-index/h1");
        }

        public static IWebElement AddExitinglink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-household-list-members/section/div/header/button[1]");
        }
        public static IWebElement AddExitingHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household/app-add-existing-client-search/section/div[1]/h2");
        }

        public static IWebElement AddNewLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-household-list-members/section/div/header/button[2]");
        }
        public static IWebElement AddNewHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-client/app-create-client-index/div/h1");
        }

        public static IWebElement EditHouseholdLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-household-list-members/section/div/header/button[3]");
        }
        public static IWebElement EditHouseholdHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/main/div/app-household/app-household-composition/h2");
        }

		public static IWebElement AddContact()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-household-contact-information/section/div/header/button");
		}

		public static IWebElement AddContactHeader()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-create-household-contact-information/section/h2");
		}
	}
}
