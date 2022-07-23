using OpenQA.Selenium;

namespace SheridanAutoProject.Pages
{
    public class GitRepoPage
    {
        private readonly IWebDriver _driver;
        private readonly By _googleSearchBox = By.ClassName("");

        public GitRepoPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Action()
        {

        }
        //public bool IsSheridanRepoDisplayed()
        //{
        //    var isSheridanRepoDisplayed = _driver.IsElementPresent(_repoElement, maxLoadTimeSeconds);
        //    return isSheridanRepoDisplayed;
        //}
    }
}
