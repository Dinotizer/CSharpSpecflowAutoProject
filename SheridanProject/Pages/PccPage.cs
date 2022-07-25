using System;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SheridanAutoProject.Pages
{
    public class PccPage
    {
        private readonly IWebDriver _driver;
        private readonly By _PccLogoLink = By.ClassName("logo__link");

        //public LinkedInPage(IWebDriver driver, IWebElement element)
        public PccPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool isPccSiteDisplayed()
        {
            var isPccSiteDisplayed = _driver.FindElement(_PccLogoLink);
            return isPccSiteDisplayed.Displayed;
        }
    }
}
