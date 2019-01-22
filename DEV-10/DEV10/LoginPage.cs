using System;
using OpenQA.Selenium;

namespace DEV10
{
    public class LoginPage
    {
        private IWebElement login = Browser.Driver.FindElement(By.XPath("//*[@id='top']"));
        public void OpenLoginPage()
        {
            login.Click();
        }
    }
}