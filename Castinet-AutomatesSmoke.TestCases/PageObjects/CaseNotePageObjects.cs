using Castinet_AutomatesSmoke.TestCases.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.PageObjects
{
    public class CaseNotePageObjects
    {
        public static IWebElement CaseNoteLink()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/app-left-nav/aside/nav/a[5]/span");
        }

        public static IWebElement CaseNoteHeader()
        {
            return WebDriverUtils.WaitForElementByXpath("//*/div/mat-dialog-container/app-case-note-create/form/section[1]/h4");
        }
    }
}
