using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class UserPageObjects
    {
        public static IWebElement UserLink()
        {
            return WebDriverUtils.WaitForElementByCss("#subnavUsers");
        }

        public static IWebElement CreateNewUserLink()
        {
            return WebDriverUtils.WaitForElementByCss("app-admin-system-core > app-users > a");
        }

        public static IWebElement CreateNewUserHeader()
        {
            return WebDriverUtils.WaitForElementByCss("app-create-user-index > div > form > div > app-create-user > h3");
        }
    }
}
