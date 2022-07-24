using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SheridanAutoProject.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}