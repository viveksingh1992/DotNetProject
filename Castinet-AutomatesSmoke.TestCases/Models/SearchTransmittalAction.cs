using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class SearchTransmittalAction
    {
        public static void TransmittalSearchAction()
        {
            TransmittalNavigation.TransmittalNavigationAction();
            WebDriverUtils.ClearField(TransmittalPageObjects.StartDateField());
            WebDriverUtils.InputValues(TransmittalPageObjects.StartDateField(), TestEnvironment.LoadJson().Finance.StartDate);
            WebDriverUtils.ClickAction(TransmittalPageObjects.SearchTransmittalButton());
        }
    }
}
