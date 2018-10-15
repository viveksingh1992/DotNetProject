using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;

namespace Castinet_AutomatesSmoke.TestCases.Utilities
{
    
    public class TestBase
    {
        [TestInitialize()]
        public void BeforeMethod()
        {
            WebDriverUtils.OpenBrowser();
            WebDriverUtils.Maximize();
            WebDriverUtils.GoToURL(TestEnvironment.LoadJson().Url.Cak);
        }

        [TestCleanup()]
        public void AfterMethod()
        {
            WebDriverUtils.HoldDriver();
            WebDriverUtils.CloseWindow();
        }
    }
}
