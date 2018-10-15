using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class HouseholdAddressPageObjects
    {
        public static IWebElement AddAddresslink()
        {
            return WebDriverUtils.WaitForElementByXpath("//app-physical-address-read/section/div/header/button/i");
        }
    }
}
