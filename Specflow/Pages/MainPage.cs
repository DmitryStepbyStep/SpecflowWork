using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool isLoginSuccessfull()
        {
            bool isLoginSuccessfull = false;
            try
            {
                IWebElement homePageLabel = driver.FindElement(By.XPath(".//*[text()='Home page']"));
                isLoginSuccessfull = homePageLabel.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isLoginSuccessfull = false;
            }
            return isLoginSuccessfull;
        }
        public bool isAddSuccessfull()
        {
            bool isAddSuccessfull = false;
            try
            {
                IWebElement add = driver.FindElement(By.LinkText("Charlotte"));
                isAddSuccessfull = add.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isAddSuccessfull = false;
            }
            return isAddSuccessfull;
        }
        public bool isCheckSuccessfull()
        {
            bool isCheckSuccessfull = false;
            try
            {
                IWebElement add = driver.FindElement(By.LinkText("All Products"));
                isCheckSuccessfull = add.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isCheckSuccessfull = false;
            }
            return isCheckSuccessfull;
        }
        public bool isDeleteSuccessfull()
        {
            bool isDeleteSuccessfull = false;
            try
            {
                IWebElement delete = driver.FindElement(By.LinkText("Charlotte"));
                isDeleteSuccessfull = delete.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isDeleteSuccessfull = false;
            }
            return isDeleteSuccessfull;
        }

    }
}