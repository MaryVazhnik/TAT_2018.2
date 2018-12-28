using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DEV10
{
    public class StartPage
    {
        private IWebElement surenameInput = Browser.Driver.FindElement(By.XPath("//*input[@id='login']"));
        private IWebElement searchButton = Browser.Driver.FindElement(By.XPath("//*input[@class='commandExButton]'"));
        private IWebElement passwordInput = Browser.Driver.FindElement(By.XPath("//*input[@id='password']"));

        private IWebElement confirmationInput =
            Browser.Driver.FindElement(By.XPath("//*input[@id='viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:conf']"));
        public void Search()
        {
            surenameInput.Click();
            surenameInput.SendKeys("donmarino79");
            passwordInput.Click();
            passwordInput.SendKeys("donmarino79");
            searchButton.Click();
            confirmationInput.Click();
        }
    }
}