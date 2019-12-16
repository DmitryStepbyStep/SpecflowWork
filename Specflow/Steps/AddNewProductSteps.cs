using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumBasicsDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps
{
    [Binding]
    public class AddNewProductSteps
    {
        private IWebDriver driver;
        [Given(@"I open ""(.*)"" pages")]
        public void GivenIOpenPages(string pages)
        {
            driver = new ChromeDriver();
            driver.Url = pages;
        }
        
        [When(@"I login with ""(.*)"" username and ""(.*)"" passwoord")]
        public void WhenILoginWithUsernameAndPasswoord(string login, string password)
        {
            new LoginPage(driver).Login(login, password);
        }
        
        [When(@"I Click button ""(.*)"" and ""(.*)""")]
        public void WhenIClickButtonAnd(string p0, string p1)
        {
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.LinkText("Create new")).Click();
        }
        
        [When(@"I have entered product with product ""(.*)"" and ""(.*)"" UnitPrice and CLick Send button")]
        public void WhenIHaveEnteredProductWithProductAndUnitPriceAndCLickSendButton(string product, string unitptice)
        {
            new Add_product_Page(driver).Add(product, unitptice);
            driver.FindElement(By.CssSelector(".btn")).Click();
        }
        
        [Then(@"Product added is succesful add")]
        public void ThenProductAddedIsSuccesfulAdd()
        {
            Assert.IsTrue(new MainPage(driver).isAddSuccessfull(), "Product Add successeful");
            driver.Quit();
        }
    }
}
