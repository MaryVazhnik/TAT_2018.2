using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace SearchOnVK
{
    class SearchElements
    {
        IWebDriver driver = new ChromeDriver();
        public void Info(string login, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://vk.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='index_email']")).SendKeys(login);
            driver.FindElement(By.XPath("//*[@id='index_pass']")).SendKeys(password + Keys.Enter);

            driver.FindElement(By.XPath("//li[@id='l_msg']")).Click();
            driver.FindElement(By.XPath("//a[@id='ui_rmenu_unread']")).Click();

            IWebElement name = driver.FindElement(By.XPath("//span[@class= '_im_dialog_link']"));
            IWebElement message = driver.FindElement(By.XPath("//div[@class= 'nim-dialog--cw']"));
            IWebElement date = driver.FindElement((By.XPath("//div[@class= 'nim-dialog--date_im_dialog_date']")));
            Console.WriteLine(name.Text + "   " + date.Text);
            Console.WriteLine(message.Text);
        }
    }
}