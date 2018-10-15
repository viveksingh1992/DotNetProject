using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class PartnerOverviewAction
    {
        public static void PartnerOverviewNavigation()
        {
            PartnerAdminSearch.PartnerSearchAction();
            WebDriverUtils.ClickAction(PartnerPageObjects.ProgramDetailsLink());
        }
    }
}
