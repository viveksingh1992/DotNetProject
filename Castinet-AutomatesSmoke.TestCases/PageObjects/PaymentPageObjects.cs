using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
	public class PaymentPageObjects
	{
		public static IWebElement PaymentNavLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//*[@href='/finance/payments']");
		}

		public static IWebElement PaymentSearchHeaderLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//section[1]/div/h2");
		}

		public static IWebElement CreatePaymentLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//app-list-payment-application/section/div/header/button");
		}

		public static IWebElement CreatePaymentHeaderLink()
		{
			return WebDriverUtils.WaitForElementByXpath("//section[1]/div/h2");
		}
	}
}
