using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV10
{
    public static class Browser
    {
        public static IWebDriver Driver { get; set; }
        public static bool Initialised { get; set; }

        public static void Initialize()
        {
            Driver = new ChromeDriver();
            Initialised = true;
        }

        public static void Quit()
        {
            Driver.Quit();
            Initialised = false;
        }
    }
}