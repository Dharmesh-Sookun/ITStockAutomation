using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class Login
    {

        public static void EnterUsername(string username)
        {
            BaseMethods.SendKeys(username, "//input[@id='inputEmail']");
        }

        public static void EnterPassword(string password)
        {
            BaseMethods.SendKeys(password, "//input[@id='inputPassword']");
        }

        public static void ClickLogin(string locator)
        {
            BaseMethods.Click(locator);
        }
    }
}
