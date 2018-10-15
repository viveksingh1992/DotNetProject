using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class ClientSearchAction
    {
        public static void SearchAction()
        {
            var data = TestEnvironment.LoadJson();
            WebDriverUtils.InputValues(LoginPageObjects.EmailField(), data.Login.Username);
            WebDriverUtils.ClickAction(LoginPageObjects.NextButtonEmail());
            WebDriverUtils.InputValues(LoginPageObjects.PasswordField(), data.Login.Password);
            WebDriverUtils.ClickAction(LoginPageObjects.SignInButton());
            WebDriverUtils.ClickAction(LoginPageObjects.YesButton());
            WebDriverUtils.ClickAction(LoginPageObjects.DoneButton());
            WebDriverUtils.ClickAction(ClientPageObjects.ClientTab());
            WebDriverUtils.ClickAction(ClientSearchPageObjects.DobField());
            WebDriverUtils.InputValues(ClientSearchPageObjects.DobField(), data.ClientSearch.Month);
            WebDriverUtils.InputValues(ClientSearchPageObjects.DobField(), data.ClientSearch.Date);
            WebDriverUtils.InputValues(ClientSearchPageObjects.DobField(), data.ClientSearch.Year);
            WebDriverUtils.ClickAction(ClientSearchPageObjects.RunSearchButton());
        }

        public static void SearchActionUsingLastName()
        {
            var data = TestEnvironment.LoadJson();
            WebDriverUtils.InputValues(LoginPageObjects.EmailField(), data.Login.Username);
            WebDriverUtils.ClickAction(LoginPageObjects.NextButtonEmail());
            WebDriverUtils.InputValues(LoginPageObjects.PasswordField(), data.Login.Password);
            WebDriverUtils.ClickAction(LoginPageObjects.SignInButton());
            WebDriverUtils.ClickAction(LoginPageObjects.YesButton());
            WebDriverUtils.ClickAction(LoginPageObjects.DoneButton());
            WebDriverUtils.ClickAction(ClientPageObjects.ClientTab());
            WebDriverUtils.InputValues(ClientSearchPageObjects.LastNameField(), data.LastName.Name);
            WebDriverUtils.ClickAction(ClientSearchPageObjects.RunSearchButton());
        }
    }
}
