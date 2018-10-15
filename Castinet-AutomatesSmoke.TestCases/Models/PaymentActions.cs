using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
	public class PaymentActions
	{
		public static void NavigateSearchPayments()
		{
			LoginAction.Login();
			WebDriverUtils.ClickAction(TransmittalPageObjects.FinanceTabLink());
			WebDriverUtils.ClickAction(PaymentPageObjects.PaymentNavLink());
		}

		public static void NavigateCreatePayments()
		{
			LoginAction.Login();
			WebDriverUtils.ClickAction(TransmittalPageObjects.FinanceTabLink());
			WebDriverUtils.ClickAction(PaymentPageObjects.PaymentNavLink());
			WebDriverUtils.ClickAction(PaymentPageObjects.CreatePaymentLink());
		}
	}
}
