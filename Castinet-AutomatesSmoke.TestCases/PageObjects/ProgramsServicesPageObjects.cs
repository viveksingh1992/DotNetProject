using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class ProgramsServicesPageObjects
    {
        public static IWebElement ProgramsServiceslink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-left-nav/aside/nav/a[3]/span");
        }

        public static IWebElement ProgramsServicesHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-programs-index/div/app-header/section/div/h1");
        }

        public static IWebElement ProgramsServicesReferOutButton()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-header/section/div/div[1]/button");
        }

        public static IWebElement ProgramsServicesReferOutHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-household/app-create-program-service-referral/app-header/section/div/h1");
        }

		public static IWebElement ReferralLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//mat-row[1]/mat-cell[1]/a");
		}

		public static IWebElement FollowUpLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//mat-cell[5]/a");
		}

		public static IWebElement FollowUpHeader()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-view-follow-up/app-header/section/div/h1");
		}
	}
}
