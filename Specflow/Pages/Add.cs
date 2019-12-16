using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{

    class Add_product_Page
    {
        private IWebDriver driver;

        public Add_product_Page(IWebDriver driver)
        {
            this.driver = driver;
           // this.All_Products = driver.FindElement(By.LinkText("All Products"));
           // this.Create_new = driver.FindElement(By.LinkText("Create new"));
            this.Product_Name = driver.FindElement(By.Id("ProductName"));
            this.Category_Id = driver.FindElement(By.Id("CategoryId"));
            this.Supplier_Id = driver.FindElement(By.Id("SupplierId"));
            this.Unit_Price = driver.FindElement(By.Id("UnitPrice"));
            //this.Button_OK = driver.FindElement(By.CssSelector(".btn"));
        }

       // private IWebElement All_Products;
       // private IWebElement Create_new;
        private IWebElement Product_Name;
        private IWebElement Category_Id;
        private IWebElement Supplier_Id;
        private IWebElement Unit_Price;
        //private IWebElement Button_OK;



        public MainPage Add(String product, String unitprice)
        {


           // All_Products.Click();
           // Create_new.Click();
            Product_Name.SendKeys(product);
            Product_Name.Click();

            Category_Id.Click();
            Category_Id.FindElement(By.XPath("//option[. = 'Confections']")).Click();
            Supplier_Id.Click();
            Supplier_Id.FindElement(By.XPath("//option[. = 'Exotic Liquids']")).Click();

            Unit_Price.SendKeys(unitprice);
            Unit_Price.Click();

           // Button_OK.Click();

            return new MainPage(driver);
        }
    }
}
