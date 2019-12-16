using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumBasicsDemo;
using SpecflowTests.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps
{
    [Binding]
    public class Delete_Product_2Steps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" p")]
        public void GivenIOpenP(string p)
        {
            driver = new ChromeDriver();
            driver.Url = p;
        }
        
        [When(@"I login with ""(.*)"" u and ""(.*)"" pa")]
        public void WhenILoginWithUAndPa(string login, string password)
        {
            new LoginPage(driver).Login(login, password);
        }
        
        [When(@"I Click button ""(.*)""  and delete product")]
        public void WhenIClickButtonAndDeleteProduct(string p0)
        {
            driver.FindElement(By.LinkText("All Products")).Click();
            new Delete_Product(driver).DeleteProduct();
        }
        
        [Then(@"Product delete is succesful")]
        public void ThenProductDeleteIsSuccesful()
        {
            Assert.IsTrue(new MainPage(driver).isDeleteSuccessfull(), "Product Delete successfull ");
            driver.Quit();
        }
    }
}
