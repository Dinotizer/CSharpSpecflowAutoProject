Feature: GoogleSearch

@googleSearch
Scenario: I can search for my LinkedIn account on Google
	Given the Google webpage is present
	When we search for Sheridan Irvine's LinkedIn profile
	Then the Google search results should include a link to the LinkedIn profile

@googleSearch
Scenario: I can select my LinkedIn link from the Google search results
	Given Sheridan Irvine's LinkedIn link is present in the search results
	When we select it
	Then we are directed to the LinkedIn profile page