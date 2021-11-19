using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumWebDriver
{
    public class WebDriverFactory
    {
        public IWebDriver GetWebDriver(BrowserEnum browserEnum = BrowserEnum.EDGE)
        {
            IWebDriver driver;
            switch(browserEnum)
            {
                case BrowserEnum.CHROME: driver = new ChromeDriver(@"C:\Driver");
                    break;
                case BrowserEnum.EDGE: driver = new EdgeDriver(@"C:\Webdriver\bin");
                    break;
                default: driver = new FirefoxDriver(@"C:\Driver", CustomFirefoxOptions.getOptions());
                    break;
            }
            return driver;
        }
    }
}
