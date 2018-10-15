using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
	[TestClass]
	public class PaymentTestCases : TestBase
	{
		ILog log = LogManager.GetLogger("ErrorLog");
		[TestMethod]
		public void PaymentNavigationTest()
		{
			try
			{
				PaymentActions.NavigateSearchPayments();
				Assert.AreEqual(TestEnvironment.LoadJson().Finance.PaymentSearchHeader, WebDriverUtils.TextChecker(PaymentPageObjects.PaymentSearchHeaderLink()));
				log.Info(System.Reflection.MethodBase.GetCurrentMethod());
				log.Info(LoginPageObjects.SuccessMessage());
			}
			catch (Exception ex)
			{

				log.Error(System.Reflection.MethodBase.GetCurrentMethod());
				log.Error(LoginPageObjects.FailedMessage() + ex.Message);
				Assert.Fail(ex.Message);
			}
		}

		[TestMethod]
		public void CreatePaymentNavigationTest()
		{
			try
			{
				PaymentActions.NavigateCreatePayments();
				Assert.AreEqual(TestEnvironment.LoadJson().Finance.CreatePaymentHeader, WebDriverUtils.TextChecker(PaymentPageObjects.CreatePaymentHeaderLink()));
				log.Info(System.Reflection.MethodBase.GetCurrentMethod());
				log.Info(LoginPageObjects.SuccessMessage());
			}
			catch (Exception ex)
			{

				log.Error(System.Reflection.MethodBase.GetCurrentMethod());
				log.Error(LoginPageObjects.FailedMessage() + ex.Message);
				Assert.Fail(ex.Message);
			}
		}
	}
}
