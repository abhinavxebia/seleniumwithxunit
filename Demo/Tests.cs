using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Demo
{
    public class Tests : IDisposable
    {
        public IWebDriver driver;

        //Constructor to initiate browser instance
        public Tests() {

            try {
                driver = new ChromeDriver();
            }
            catch (Exception e) {
                Console.WriteLine("Exception while starting chrome..." +e);
            }
        }

        [Fact]
        public void ValidateWikiTitle() {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            Assert.Equal("Wikipedia, the free encyclopedia", driver.Title);
        }

        //Stopping browser instance
        public void Dispose()
        {
            try {
                driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while stopping chrome..." + e);
            }
        }
    }
}
