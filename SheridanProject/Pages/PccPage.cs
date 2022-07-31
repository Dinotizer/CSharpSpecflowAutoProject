using SheridanProject.Utilities;

namespace SheridanAutoProject.Pages
{
    public class PccPage
    {
        private readonly IWebDriver _driver;
        private readonly By _pccLogoLink = By.ClassName("logo__link");
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
