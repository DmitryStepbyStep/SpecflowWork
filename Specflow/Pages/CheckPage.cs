using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumBasicsDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowTests.Pages
{
    class CheckPage
    {
        private IWebDriver driver;

        public CheckPage(IWebDriver driver)
        {
            this.driver = driver;
            //this.All_Products = driver.FindElement(By.LinkText("All Products"));
            // this.Element = driver.FindElement(By.LinkText("Charlotte"));
            this.Product_Name = driver.FindElement(By.Id("ProductName"));
            this.Category_Id = driver.FindElement(By.Id("CategoryId"));
            this.Supplier_Id = driver.FindElement(By.Id("SupplierId"));
            this.Unit_Price = driver.FindElement(By.Id("UnitPrice"));
            //this.Button_OK = driver.FindElement(By.CssSelector(".btn"));
        }
        //private IWebElement All_Products;
        //private IWebElement Element;
        private IWebElement Product_Name;
        private IWebElement Category_Id;
        private IWebElement Supplier_Id;
        private IWebElement Unit_Price;
       // private IWebElement Button_OK;

        public MainPage Check(String product, String unitptice)
        {
           // All_Products.Click();
           // Element.Click();
            
            Assert.AreEqual(Product_Name.GetAttribute("value"), product);
            Assert.AreEqual(Category_Id.FindElement(By.CssSelector("#CategoryId > option:nth-child(4)")).GetAttribute("text"), "Confections");
            Assert.AreEqual(Supplier_Id.FindElement(By.XPath("//option[. = 'Exotic Liquids']")).GetAttribute("text"), "Exotic Liquids");
            Assert.AreEqual(Unit_Price.GetAttribute("value"), unitptice);
           
           // Button_OK.Click();

            return new MainPage(driver);
        }

    }
}
