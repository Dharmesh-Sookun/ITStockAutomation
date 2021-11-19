using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class BaseMethods
    {
        //static IWebDriver driver = new FirefoxDriver("C:\\Driver", CustomFirefoxOptions.getOptions());
        static IWebDriver driver = new WebDriverFactory().GetWebDriver();
        static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        
        public static void OpenURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void SendKeys(string text, string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            driver.FindElement(By.XPath(locator)).SendKeys(text);
        }

        public static void Click(string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            driver.FindElement(By.XPath(locator)).Click();
        }

        public static void ClickCSS(string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            driver.FindElement(By.CssSelector(locator)).Click();
        }

        public static string GetURL()
        {
            return driver.Url;
        }

        public static int CountNumOfRows(string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            return driver.FindElements(By.XPath(locator)).Count;
        } 

        public static string GetInnerText(string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            return driver.FindElement(By.XPath(locator)).Text;
        }

        public static void ClearField(string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            driver.FindElement(By.XPath(locator)).Clear();
        }

        public static void SelectFromDropdown(string name, string locator)
        {
            wait.Until(webDriver => webDriver.FindElement(By.XPath(locator)).Displayed);
            SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath(locator)));
            dropdown.SelectByText(name);
        }

        public static void DisposeWebDriver()
        {
            //driver.Dispose();
        }

    }
}
