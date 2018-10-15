using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class FundingSourceAdminSearch
    {
        public static void FundingSourceSearchTest()
        {
            var data = TestEnvironment.LoadJson();
            WebDriverUtils.InputValues(LoginPageObjects.EmailField(), data.Login.Username);
            WebDriverUtils.ClickAction(LoginPageObjects.NextButtonEmail());
            WebDriverUtils.InputValues(LoginPageObjects.PasswordField(), data.Login.Password);
            WebDriverUtils.ClickAction(LoginPageObjects.SignInButton());
            WebDriverUtils.ClickAction(LoginPageObjects.YesButton());
            WebDriverUtils.ClickAction(LoginPageObjects.DoneButton());
            WebDriverUtils.ClickAction(ProgramsPageObjects.ProgramHeaderLink());
            WebDriverUtils.ClickAction(FundingSourcePageObjects.FundingSourceLink());
            WebDriverUtils.InputValues(FundingSourcePageObjects.SearchFundingSourceField(), data.FundingSource.FundSearchKeyword);
            WebDriverUtils.ClickAction(FundingSourcePageObjects.FundingSourceRunSearch());
        }
    }
}
