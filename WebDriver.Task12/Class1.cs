using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver.Task12
{
    public class Class1
    {
        private IWebDriver chromeDriver;

        [SetUp]
        public void start_Browser()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://gismeteo.ua/");

        }

        [Test]
        public void FindPageElements()
        {         
            chromeDriver.FindElement(By.XPath("//div"));
            chromeDriver.FindElement(By.CssSelector("div"));
            chromeDriver.FindElement(By.XPath("//div[@class='readmore_item']"));
            chromeDriver.FindElement(By.CssSelector("div.readmore_item"));
            chromeDriver.FindElement(By.XPath("//span[@class = 'cities_name']"));
            chromeDriver.FindElement(By.CssSelector("span.cities_name"));
            chromeDriver.FindElement(By.XPath("//div[@class='readmore_title nolink white']"));
            chromeDriver.FindElement(By.CssSelector("div.readmore_title.nolink.white"));
            chromeDriver.FindElement(By.XPath("//span[text() = 'Киев']"));
            chromeDriver.FindElement(By.XPath("//div[@class = 'cities_list']/div[8]"));
            chromeDriver.FindElement(By.XPath("//nav[@ class = 'nav_block nav_type_menu']/ul/*"));
            chromeDriver.FindElement(By.CssSelector("ul.nav_list>li"));
            chromeDriver.Navigate().GoToUrl("https://www.gismeteo.ua/weather-kharkiv-5053/");
            chromeDriver.FindElement(By.XPath("//div[@class = 'tabs _center']"));
            chromeDriver.FindElement(By.CssSelector("div.tabs"));
            chromeDriver.FindElement(By.XPath("//div[@class = 'tab  tooltip']"));
            chromeDriver.FindElement(By.CssSelector("div.tab"));
            chromeDriver.FindElement(By.XPath("//div[@class = 'chart chart__temperatureTab']"));
            chromeDriver.FindElement(By.CssSelector("div.chart.chart__temperatureTab"));

        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Quit();
        }

    }
}
