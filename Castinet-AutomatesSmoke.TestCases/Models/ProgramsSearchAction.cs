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
    public class ProgramsSearchAction
    {
        public static void ProgramSearchAction()
        {
            var data = TestEnvironment.LoadJson();
            WebDriverUtils.InputValues(LoginPageObjects.EmailField(), data.Login.Username);
            WebDriverUtils.ClickAction(LoginPageObjects.NextButtonEmail());
            WebDriverUtils.InputValues(LoginPageObjects.PasswordField(), data.Login.Password);
            WebDriverUtils.ClickAction(LoginPageObjects.SignInButton());
            WebDriverUtils.ClickAction(LoginPageObjects.YesButton());
            WebDriverUtils.ClickAction(LoginPageObjects.DoneButton());
            WebDriverUtils.ClickAction(ProgramsPageObjects.ProgramHeaderLink());
            WebDriverUtils.HoldDriver();
            WebDriverUtils.InputValues(ProgramsPageObjects.ProgramSearchField(), data.Programs.ProgramKeyword);
            WebDriverUtils.HoldDriver();
            WebDriverUtils.ClickAction(ProgramsPageObjects.RunSearch());
        }
    }
}
