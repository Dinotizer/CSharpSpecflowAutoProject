using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheridanProject.StepDefinitions
{
    [Binding]
    internal class GoogleSearchStepDefinitions
    {
        [Given(@"the Google webpage is present")]
        public void GivenTheGoogleWebpageIsPresent()
        {
            throw new PendingStepException();
        }

        [When(@"we search for Sheridan Irvine's GitHub Repo")]
        public void WhenWeSearchForSheridanIrvinesGitHubRepo()
        {
            throw new PendingStepException();
        }

        [Then(@"the Google search results should include a link to the Repo")]
        public void ThenTheGoogleSearchResultsShouldIncludeALinkToTheRepo()
        {
            throw new PendingStepException();
        }

        [Given(@"Sheridan Irvine's GitHub Repo is present in the search results")]
        public void GivenSheridanIrvinesGitHubRepoIsPresentInTheSearchResults()
        {
            throw new PendingStepException();
        }

        [When(@"we select it")]
        public void WhenWeSelectIt()
        {
            throw new PendingStepException();
        }

        [Then(@"we are directed to the GitHub Repo wep page")]
        public void ThenWeAreDirectedToTheGiyHubRepoWepPage()
        {
            throw new PendingStepException();
        }
    }
}
