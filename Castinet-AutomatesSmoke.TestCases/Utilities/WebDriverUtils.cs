using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Castinet_AutomatesSmoke.TestCases.Utilities
{
    public class WebDriverUtils
    {
        public static IWebDriver driver = null;
        public static IWebDriver OpenBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            return driver;
        }

        public static void GoToURL(string Url)
        {
            driver.Url = Url;
        }

        public static IWebElement ElementUsingID(string ID)
        {
            return driver.FindElement(By.Id(ID));
        }

        public static IWebElement ElementUsingCssSelector(string Css)
        {
            return driver.FindElement(By.CssSelector(Css));
        }

        public static void ClickAction(IWebElement e)
        {
            e.Click();
        }

        public static void InputValues(IWebElement e, string s)
        {
            e.SendKeys(s);
        }


        public static IWebElement WaitForElementByID(string e)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            #pragma warning disable CS0618
            IWebElement el = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(e)));
            #pragma warning restore CS0618
            return el;
        }

        public static IWebElement WaitForElementByCss(string e)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            #pragma warning disable CS0618
            IWebElement el = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(e)));
            #pragma warning restore CS0618
            return el;
        }

        public static IWebElement WaitForElementByXpath(string e)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            #pragma warning disable CS0618
            IWebElement el = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(e)));
            #pragma warning restore CS0618
            return el;
        }

        public static string TextChecker(IWebElement e)
        {
            string s = e.Text;
            return s;
        }

        public static void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public static void CloseWindow()
        {
            driver.Close();
            driver.Dispose();
        }

        public static void HoldDriver()
        {
            Thread.Sleep(3000);
        }

        public static void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,100)");
        }

        public static void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public static void ScrollToTop()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
        }

        public static void WaitAndClickAction(IWebElement e)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            #pragma warning disable CS0618
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(e));
            #pragma warning restore CS0618
            element.Click();
        }

        public static void MoveToElementAndClick(string s)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            #pragma warning disable CS0618
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(s)));
            #pragma warning restore CS0618

            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Build().Perform();
        }

        public static void ClearField(IWebElement ElementToBeCleared)
        {
            ElementToBeCleared.Clear();
        }

        public static void ClickOnStaleElement(string s)
        {
            for (int i = 0; i <= 2; i++)

            {

                try
                {

                    driver.FindElement(By.XPath(s)).Click();

                    break;

                }

                catch (Exception e)
                {

                    Console.WriteLine("lement not found because: " + e);

                }
            }
        }

        public static void SelectOption(string xpath, string ToBoMatched)
        {
            IList<IWebElement> Elementlist = driver.FindElements(By.XPath(xpath));

            for (int i=0; i<Elementlist.Count; i++)

            {
                string s = Elementlist[i].Text;
                if (s.Equals(ToBoMatched))
                {
                    Elementlist[i].Click();
                }
            }            
        }
    }
}