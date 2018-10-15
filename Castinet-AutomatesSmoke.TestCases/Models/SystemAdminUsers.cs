using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class SystemAdminUsers
    {
        public static void AdminUserNavigationAction()
        {
            SystemAdminOrganization.OrganizationNavigation();
            WebDriverUtils.ClickAction(UserPageObjects.UserLink());
        }
    }
}
