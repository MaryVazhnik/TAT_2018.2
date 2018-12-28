using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DEV10
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void SetUp()
        {
            if (!Browser.Initialised)
            {
                Browser.Initialize();
            }
            Browser.Driver.Url = "https://poezd.rw.by.";
            Browser.Driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void LoginToSystem()
        {
            Pages.LoginPage.OpenLoginPage();
            Pages.StartPage.Search();
        }

        [TestMethod]
        public void RouteSelection()
        {
            Pages.RoutePage.Search();
        }

        [TestMethod]
        public void IncorrectRout()
        {
            Pages.RoutePage.IncorrectData();
        }
        [TestCleanup]
        public void TearDown()
        {
            Browser.Quit();
        }
    }
}