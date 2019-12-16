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
    public class Check_ProductSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" pag")]
        public void GivenIOpenPag(string pag)
        {
            driver = new ChromeDriver();
            driver.Url = pag;
        }
        
        [When(@"I login with ""(.*)"" us and ""(.*)"" pas")]
        public void WhenILoginWithUsAndPas(string login, string password)
        {
            new LoginPage(driver).Login(login, password);
        }
        
        [When(@"I Check product")]
        public void WhenICheckProduct()
        {
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.LinkText("Charlotte")).Click();
            new CheckPage(driver).Check("Charlotte", "163,0000");
            driver.FindElement(By.LinkText("Products")).Click();

        }
        
        [Then(@"product exists")]
        public void ThenProductExists()
        {
            Assert.IsTrue(new MainPage(driver).isCheckSuccessfull(), "Product check ");
            driver.Quit();
        }
    }
}
