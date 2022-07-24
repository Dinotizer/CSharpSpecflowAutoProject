using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using FluentAssertions;

namespace SheridanAutoProject.Pages
{
    public class GooglePage
    {
        private readonly IWebDriver _driver;
        private readonly By _googleSearchBox = By.ClassName("gLFyf gsfi");
        private readonly By _SheridanLinkedInLink = By.LinkText("Sheridan Irvine - Test Lead - The Modern Milkman - LinkedIn");
        private readonly By _SheridanLinkedInProfilePage = By.XPath("//*[@id='main - content']/section[1]/div/section/section[1]/div/div[2]/div[1]/h1");

        public GooglePage(IWebDriver driver, IWebElement element)
        {
            _driver = driver;
        }
        public void NavigateToGoogleSite()
        {
            _driver.Navigate().GoToUrl("http://www.google.co.uk");
        }
        public void SearchForSheridanLinkedIn()
        {
            _driver.FindElement(_googleSearchBox).SendKeys("Sheridan Irvine");
        }
        public void SelectLinkedInLink()
        {
            _driver.FindElement(_SheridanLinkedInLink).Click();
        }
        //public bool IsSheridanProfileDisplayed()
        //{
        //    var isSheridanProfileDisplayed = _driver.FindElement(_SheridanLinkedInProfilePage);
        //    return isSheridanProfileDisplayed;
        //}
    }
}
