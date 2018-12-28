using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DEV10
{
    public class RoutePage
    {
        private IWebElement departureStation = Browser.Driver.FindElement(
                By.XPath("//*input[@id='viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textDepStat']"));
        private IWebElement destinationStation = Browser.Driver.FindElement(
            By.XPath("//*input[@id='viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textArrStat']"));
        private IWebElement date = Browser.Driver.FindElement(By.XPath("//*img[@class='ui-datepicker-trigger']"));
        private IWebElement day = Browser.Driver.FindElement(By.XPath("//*a[@class='ui-state-default']"));
        private IWebElement time = Browser.Driver.FindElement(By.XPath("//*span[@id='viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6129a']"));
        private IWebElement continueButton = Browser.Driver.FindElement(By.XPath("//*input[@id='viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:buttonSearch']"));

        public void Search()
        {
            departureStation.Click();
            departureStation.SendKeys("Гомель");
            destinationStation.Click();
            destinationStation.SendKeys("Минск-Пассажирский");
            date.Click();
            day.Click();
            time.Click();
            continueButton.Click();
        }

        public void IncorrectData()
        {
            departureStation.Click();
            departureStation.SendKeys("Гооомель");
            destinationStation.Click();
            destinationStation.SendKeys("");
            date.Click();
            day.Click();
            time.Click();
            continueButton.Click();
        }
    }
}