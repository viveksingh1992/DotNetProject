using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class ClientPageObjects
    {
        public static IWebElement ClientTab()
        {
            return WebDriverUtils.WaitForElementByCss("#navClients>span");
        }

        public static IWebElement ClientSearchText()
        {
            return WebDriverUtils.WaitForElementByCss(".form__section.-justifyCenter>div>h2");
        }
    }
}
