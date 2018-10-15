using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
	public class TransmittalOverviewAction
	{
		public static void TransmittalOverviewNavigation()
		{
			SearchTransmittalAction.TransmittalSearchAction();
			WebDriverUtils.ClickAction(TransmittalPageObjects.TransmittalOverviewNavigaterLink());
		}
	}
}
