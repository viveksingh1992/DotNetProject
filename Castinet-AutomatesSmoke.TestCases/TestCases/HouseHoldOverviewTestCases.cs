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
    public class HouseHoldOverviewTestCases : TestBase
    {
        ILog log = LogManager.GetLogger("ErrorLog");
        [TestMethod]
        public void HouseHoldOverviewNavigation()
        {
            try
            {
                HouseHoldOverviewAction.HouseHoldOverview();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.HeadingText, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.HoHeading()));
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
        public void HouseHoldOverviewEditAddressTest()
        {
            try
            {
                HouseHoldOverviewAction.HouseHoldOverviewEditAddress();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.EditAddressHeader, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.EditAddressHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void HouseHoldOverviewAddExitingTest()
        {
            try
            {
                HouseHoldOverviewAction.HouseHoldOverviewAddExiting();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.Addexisting, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.AddExitingHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void HouseHoldOverviewEditAddNewTest()
        {
            try
            {
                HouseHoldOverviewAction.HouseHoldOverviewAddNew();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.Addnew, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.AddNewHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void HouseHoldOverviewEditHouseholdTest()
        {
            try
            {
                HouseHoldOverviewAction.HouseHoldOverviewEditHousehold();
                Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.Edithousehold, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.EditHouseholdHeader()));
                log.Info(System.Reflection.MethodBase.GetCurrentMethod());
                log.Info(LoginPageObjects.SuccessMessage());
            }
            catch (Exception ex)
            {

                log.Error(System.Reflection.MethodBase.GetCurrentMethod());
                log.Error(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

		[TestMethod]
		public void HouseHoldOverviewAddContactNavigation()
		{
			try
			{
				HouseHoldOverviewAction.HouseHoldOverviewAddContact();
				Assert.AreEqual(TestEnvironment.LoadJson().HeadingHo.ContactInfoHeader, WebDriverUtils.TextChecker(HouseHoldOverviewPageObjects.AddContactHeader()));
				log.Info(System.Reflection.MethodBase.GetCurrentMethod());
				log.Info(LoginPageObjects.SuccessMessage());
			}
			catch (Exception ex)
			{

				log.Error(System.Reflection.MethodBase.GetCurrentMethod());
				log.Error(ex.Message);
				Assert.Fail(ex.Message);
			}
		}
	}
}
