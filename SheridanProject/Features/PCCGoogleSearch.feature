Feature: PCCGoogleSearch

@PCCGoogleSearch
Scenario: I can search and get to the PCC website on Google
	Given I search for Preston City Council on Google
	When I click on the PCC search result
	Then I'm directed to the PCC website