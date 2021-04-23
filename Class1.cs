using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace DotNetCoreSelenium
{
    public class Class1{

       IWebDriver _driver = new ChromeDriver("C:\\DotNetCoreSelenium\\");
        [Fact]
        public void FirstTest()
        {
            _driver.Navigate().GoToUrl("https://automationcurrypuff.home.blog");
            Assert.True(true);
        }
    }
}
