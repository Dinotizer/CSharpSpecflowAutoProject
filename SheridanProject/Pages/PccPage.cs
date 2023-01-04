using SheridanProject.Utilities;

namespace SheridanAutoProject.Pages
{
    public class PccPage
    {
        private readonly IWebDriver _driver;
        private readonly By _pccLogoLink = By.XPath("/html/body/header/nav/div/div[1]/a/img");
        public PccPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool isPccSiteDisplayed()
        {
            var isPccSiteDisplayed = _driver.FindElement(_pccLogoLink);
            return isPccSiteDisplayed.Displayed;
        }
    }
}
