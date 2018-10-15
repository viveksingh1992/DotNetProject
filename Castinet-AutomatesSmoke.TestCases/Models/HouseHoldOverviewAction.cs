using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
	public class HouseHoldOverviewAction
    {
        public static void HouseHoldOverview()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
        }

        public static void HouseHoldOverviewEditAddress()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
            WebDriverUtils.HoldDriver();
            WebDriverUtils.HoldDriver();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.EditAddressLink());
        }

        public static void HouseHoldOverviewAddExiting()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.AddExitinglink());
        }

        public static void HouseHoldOverviewAddNew()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.AddNewLink());
        }

        public static void HouseHoldOverviewEditHousehold()

        {
            ClientSearchAction.SearchAction();
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
            WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.EditHouseholdLink());
        }

		public static void HouseHoldOverviewAddContact()

		{
			ClientSearchAction.SearchAction();
			WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.ClientName());
			WebDriverUtils.ClickAction(HouseHoldOverviewPageObjects.AddContact());
		}

	}
}
