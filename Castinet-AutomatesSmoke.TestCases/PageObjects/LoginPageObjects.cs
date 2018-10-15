using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class LoginPageObjects
    {
        public static IWebElement EmailField()
        {
            return WebDriverUtils.ElementUsingID("i0116");
        }

        public static IWebElement NextButtonEmail()
        {
            return WebDriverUtils.ElementUsingID("idSIButton9");
        }

        public static IWebElement PasswordField()
        {
            return WebDriverUtils.WaitForElementByID("i0118");
        }

        public static IWebElement SignInButton()
        {
            return WebDriverUtils.WaitForElementByCss("#idSIButton9");
        }

        public static IWebElement YesButton()
        {
            return WebDriverUtils.WaitForElementByCss("#idSIButton9");
        }

        public static IWebElement DoneButton()
        {
            return WebDriverUtils.WaitForElementByCss(".btn.-large.ng-star-inserted");
        }

        public static IWebElement WelcomeText()
        {
            return WebDriverUtils.WaitForElementByCss(".jumbotron.text-center>h1>span");
        }

        public static string SuccessMessage()
        {
            return "Test Case Passed";
        }

        public static string FailedMessage()
        {
            return "Test Case Failed Because: ";
        }
    }
}
