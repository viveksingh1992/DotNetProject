using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.Models;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class IndividualOverviewAction
    {
        public static void IndividualOverview()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(IndividualOverviewPageObjects.IndividualID());
        }

        public static void EditIdentifyingIo()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(IndividualOverviewPageObjects.IndividualID());
            WebDriverUtils.ClickAction(IndividualOverviewPageObjects.EditIdentifying());
        }

        public static void EditDemographicIo()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(IndividualOverviewPageObjects.IndividualID());
            WebDriverUtils.ScrollDown();
            WebDriverUtils.ClickAction(IndividualOverviewPageObjects.EditDemographic());
        }

		public static void EditIdentificationIo()

		{
			ClientSearchAction.SearchAction();
			WebDriverUtils.ClickAction(IndividualOverviewPageObjects.IndividualID());
			WebDriverUtils.HoldDriver();
			WebDriverUtils.ScrollDown();
			WebDriverUtils.ClickAction(IndividualOverviewPageObjects.EditIdentificationLink());
		}

		public static void RemoveIdentificationIo()

		{
			ClientSearchAction.SearchAction();
			WebDriverUtils.ClickAction(IndividualOverviewPageObjects.IndividualID());
			WebDriverUtils.HoldDriver();
			WebDriverUtils.ScrollDown();
		}

	}
}
