using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace SheridanAutoProject.Pages
{
    public class GooglePage
    {
        private readonly IWebDriver _driver;
        private readonly By _googleSearchBox = By.ClassName("gLFyf gsfi");

        public GooglePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToGoogleSite()
        {
            _driver.Navigate().GoToUrl("http://www.google.co.uk");
        }
        public void SearchForSheridanRepo()
        {
            //_googleSearchBox.SendKeys("abc"); //Need to add SendKeys definition to By class?
        }
        //public bool IsSheridanRepoDisplayed()
        //{
        //    var isSheridanRepoDisplayed = _driver.IsElementPresent(_repoElement, maxLoadTimeSeconds);
        //    return isSheridanRepoDisplayed;
        //}
    }
}
