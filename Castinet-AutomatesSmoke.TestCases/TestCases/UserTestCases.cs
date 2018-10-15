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
    public class UserTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void UserNavigationTestCases()
        {
            try
            {
                SystemAdminUsers.AdminUserNavigationAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Users.UserLink, WebDriverUtils.TextChecker(UserPageObjects.UserLink()));
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

        [TestMethod]
        public void CreateNewUserTestCases()
        {
            try
            {
                SystemAdminCreateUsers.CreateUserAction();
                Assert.AreEqual(TestEnvironment.LoadJson().Users.CreateUser, WebDriverUtils.TextChecker(UserPageObjects.CreateNewUserHeader()));
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
