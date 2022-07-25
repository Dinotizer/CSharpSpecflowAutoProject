using FluentAssertions;
using OpenQA.Selenium;
using SheridanAutoProject.Pages;
using TechTalk.SpecFlow;

namespace SheridanAutoProject.StepDefinitions
{
    [Binding]
    public class GoogleSearchStepDefinitions
    {
        private readonly GooglePage _googlePage;
        private readonly PccPage _pccPage;

        public GoogleSearchStepDefinitions(
            GooglePage googlePage, PccPage pccPage)
        {
            _googlePage = googlePage;
            _pccPage = pccPage;
        }

        [Given(@"I search for Preston City Council on Google")]
        public void GivenISearchForPrestonCityCouncilOnGoogle()
        {
            _googlePage.NavigateToGoogleSite();
            _googlePage.SearchForPrestonCityCouncil();
        }

        [When(@"I click on the PCC search result")]
        public void WhenIClickOnThePCCSearchSearchResult()
        {
            _googlePage.SelectPCCLink();
        }

        [Then(@"I'm directed to the PCC website")]
        public void ThenImDirectedToThePCCWebsite()
        {
            _pccPage.isPccSiteDisplayed();
        }
    }
}
