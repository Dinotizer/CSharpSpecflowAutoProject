using FluentAssertions;
using OpenQA.Selenium;
using SheridanAutoProject.Pages;

namespace SheridanAutoProject.StepDefinitions
{
    [Binding]
    public class GoogleSearchStepDefinitions
    {
        private readonly GooglePage _googlePage;

        public GoogleSearchStepDefinitions(
            GooglePage googlePage)
        {
            _googlePage = googlePage;
        }

        [Given(@"the Google webpage is present")]
        public void GivenTheGoogleWebpageIsPresent()
        {
            _googlePage.NavigateToGoogleSite();
        }

        [When(@"we search for Sheridan Irvine's LinkedIn profile")]
        public void WhenWeSearchForSheridanIrvinesLinkedInProfile()
        {
            _googlePage.SearchForSheridanLinkedIn();
        }

        [Then(@"the Google search results should include a link to the LinkedIn profile")]
        public void ThenTheGoogleSearchResultsShouldIncludeALinkToTheLinkedInProfile()
        {
            _googlePage.SelectLinkedInLink();
        }

        //[Given(@"Sheridan Irvine's LinkedIn link is present in the search results")]
        //public void GivenSheridanIrvinesLinkedInLinkIsPresentInTheSearchResults()
        //{
            
        //}

        //[When(@"we select it")]
        //public void WhenWeSelectIt()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"we are directed to the LinkedIn profile page")]
        //public void ThenWeAreDirectedToTheLinkedInProfilePage()
        //{
        //    throw new PendingStepException();
        //}
    }
}
