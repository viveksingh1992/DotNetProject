using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
	[TestClass]
    public class LoginTestCases : TestBase
    {
        [TestMethod]  
        [Priority(1)]
        public void LoginTest()
        {
            ILog log = LogManager.GetLogger("ErrorLog");
            try
            {
                LoginAction.Login();
                Assert.AreEqual(TestEnvironment.LoadJson().Welcome.Text, WebDriverUtils.TextChecker(LoginPageObjects.WelcomeText()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(LoginPageObjects.FailedMessage() + ex.Message);
                Assert.Fail(ex.Message);
            }
        }
    }
}
