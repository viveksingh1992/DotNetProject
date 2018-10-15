using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class PartnerAdminSearch
    {
        public static void PartnerSearchAction()
        {
            var data = TestEnvironment.LoadJson();
            WebDriverUtils.InputValues(LoginPageObjects.EmailField(), data.Login.Username);
            WebDriverUtils.ClickAction(LoginPageObjects.NextButtonEmail());
            WebDriverUtils.InputValues(LoginPageObjects.PasswordField(), data.Login.Password);
            WebDriverUtils.ClickAction(LoginPageObjects.SignInButton());
            WebDriverUtils.ClickAction(LoginPageObjects.YesButton());
            WebDriverUtils.ClickAction(LoginPageObjects.DoneButton());
            WebDriverUtils.ClickAction(ProgramsPageObjects.ProgramHeaderLink());
            WebDriverUtils.ClickAction(PartnerPageObjects.PartnerLink());
            WebDriverUtils.InputValues(PartnerPageObjects.PartnerSearchField(), data.Partners.PartnerKeyword);
            WebDriverUtils.ClickAction(PartnerPageObjects.SearchPartnerIncludeInactiveCheckbox());
            WebDriverUtils.ClickAction(PartnerPageObjects.PartnerSearchButton());
        }
    }
}
