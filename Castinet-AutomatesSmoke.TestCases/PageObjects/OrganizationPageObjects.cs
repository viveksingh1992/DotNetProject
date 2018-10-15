using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class OrganizationPageObjects
    {
        public static IWebElement SystemAdminLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*[@href='/admin-system']");
        }

        public static IWebElement OrganizationLink()
        {
            return WebDriverUtils.WaitForElementByCss("#subnavOrganization > span");
        }

        public static IWebElement CreateNewOffice()
        {
            return WebDriverUtils.WaitForElementByCss("app-admin-system-core > app-offices > p > a");
        }

        public static IWebElement CreateOfficeHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-admin-system-core > app-create-office-index > h1");
        }
    }
}
