using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castinet_AutomatesSmoke.TestCases.Models;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;
using log4net;

namespace Castinet_AutomatesSmoke.TestCases.TestCases
{
    [TestClass]
    public class ClientTestCases : TestBase
    {
        [TestMethod]
        public void ClientTest()
        {
            ILog log = LogManager.GetLogger("ErrorLog");
            try
            {
                ClientAction.Client();
                Assert.AreEqual(TestEnvironment.LoadJson().ClientSearch.Text, WebDriverUtils.TextChecker(ClientPageObjects.ClientSearchText()));
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