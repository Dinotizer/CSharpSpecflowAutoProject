using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SheridanAutoProject.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}