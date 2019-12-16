using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumBasicsDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowTests.Pages
{
    class Delete_Product
    {
        private IWebDriver driver;

        public Delete_Product(IWebDriver driver)
        {
            this.driver = driver;
           // this.All_Products = driver.FindElement(By.LinkText("All Products"));
            //this.Create_new = driver.FindElement(By.LinkText("Create new"));
            this.Element = driver.FindElement(By.CssSelector("tr:nth-child(79) > td:nth-child(12) > a"));
        
        }

       // private IWebElement All_Products;
       // private IWebElement Create_new;
        private IWebElement Element;
        



        public MainPage DeleteProduct()
        {


           // All_Products.Click();
            Element.Click();
            string DialogWindow = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(DialogWindow, "Are you sure?");
            driver.SwitchTo().Alert().Accept();

            return new MainPage(driver);
        }
    }
}
