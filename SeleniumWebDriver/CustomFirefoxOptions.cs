using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDriver
{
    public class CustomFirefoxOptions
    {
        public static FirefoxOptions getOptions()
        {
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.AcceptInsecureCertificates = true;
            return firefoxOptions;
        }
    }
}
