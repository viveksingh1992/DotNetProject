using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class ProgramsServicesAction
    {
        public static void ProgramsServices()
        {
            HouseHoldOverviewAction.HouseHoldOverview();
            WebDriverUtils.ClickAction(ProgramsServicesPageObjects.ProgramsServiceslink());
        }

        public static void ProgramsServicesReferOut()
        {
            HouseHoldOverviewAction.HouseHoldOverview();
            WebDriverUtils.ClickAction(ProgramsServicesPageObjects.ProgramsServiceslink());
            WebDriverUtils.ClickAction(ProgramsServicesPageObjects.ProgramsServicesReferOutButton());
        }

		public static void FollowUpOverviewNavigation()
		{
			HouseholdHistoryAction.HouseholdHistory();
			WebDriverUtils.HoldDriver();
			WebDriverUtils.ScrollDown();
			WebDriverUtils.ClickAction(ProgramsServicesPageObjects.ReferralLink());
			WebDriverUtils.HoldDriver();
			WebDriverUtils.ScrollDown();
			WebDriverUtils.ClickAction(ProgramsServicesPageObjects.FollowUpLink());
		}

	}
}
