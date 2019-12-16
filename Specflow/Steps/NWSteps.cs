using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumBasicsDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps
{
    [Binding]
    public class NWSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }
        
        [When(@"I login with ""(.*)"" username and ""(.*)"" password")]
        public void WhenILoginWithUsernameAndPassword(string login, string password)
        {
            new LoginPage(driver).Login(login, password);
        }
        
        [Then(@"Login is successfull")]
        public void ThenLoginIsSuccessfull()
        {
            Assert.IsTrue(new MainPage(driver).isLoginSuccessfull(), "Login failed");
            driver.Quit();
        }

        [Then(@"Login is failed")]
        public void ThenLoginIsFailed()
        {
            Assert.IsFalse(new MainPage(driver).isLoginSuccessfull(), "Login successfull for invalid credentials");
            driver.Quit();
        }
    }
}
