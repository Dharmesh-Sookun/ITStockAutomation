using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class Supplier
    {
        public static void OpenSupplierPage()
        {
            BaseMethods.Click("//div [@id = 'dijit__WidgetsInTemplateMixin_6']");
        }

        public static void OpenCreateSupplierPage()
        {
            BaseMethods.Click("//a [@href= '/Supplier/Create']");
        }

        public static void EnterName(string name)
        {
            BaseMethods.SendKeys(name, "//input[@id='inputSupplierName']");
        }

        public static void EnterPhoneNo(string phoneNo)
        {
            BaseMethods.SendKeys(phoneNo, "//input[@id='inputSupplierPhoneNo']");
        }

        public static void EnterAddress(string address)
        {
            BaseMethods.SendKeys(address, "//input[@id='inputSupplierAddress']");
        }

        public static void DeleteSupplier(int id)
        {
            BaseMethods.Click("//a [@href= '/Supplier/Delete/" + id + "']");
            BaseMethods.Click("//input [@type='submit']");
        }

        public static void ClickCreate(string locator)
        {
            BaseMethods.Click(locator);
        }

        public static string GetCurrentURL()
        {
            return BaseMethods.GetURL();
        }

        public static int GetNumberOfRowsInTable(string locator)
        {
            return BaseMethods.CountNumOfRows(locator);
        }

        public static void GetSupplierDetails(int id)
        {
            BaseMethods.Click("//a [@href= '/Supplier/Details/" + id + "']");
        }

        public static void OpenEditSupplierPage(int id)
        {
            BaseMethods.Click("//a [@href= '/Supplier/Edit/" + id + "']");
        }

        public static void ClickSave(string locator)
        {
            BaseMethods.Click(locator);
        }

        public static void ClearField(string locator)
        {
            BaseMethods.ClearField(locator);
        }

        public static string GetName()
        {
            return BaseMethods.GetInnerText("//dd [@id= 'name']");
        }

        public static void DisposeDriver()
        {
            BaseMethods.DisposeWebDriver();
        }
    }
}
