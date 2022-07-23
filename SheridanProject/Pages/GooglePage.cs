using OpenQA.Selenium;
using SheridanAutoProject.Utilities;

namespace SheridanAutoProject.Pages
{
    class GooglePage
    {
        private IWebDriver driver;

        public GooglePage()
        {
            driver = Hooks.driver;
            var _searchBox = driver.FindElement(By.ClassName("gLFyf gsfi"));
        }

        public void SendKeysToGoogle()
        {
            //_searchBox.SendKeys("Sheridan Irvine's Git Repo");
        }
    }
}
