Feature: GoogleSearch

@googleSearch
Scenario: I can search for my GitHub Repo on Google
	Given the Google webpage is present
	When we search for Sheridan Irvine's GitHub Repo
	Then the Google search results should include a link to the Repo

@googleSearch
Scenario: I can select my GitHub Repo link from the Google search results
	Given Sheridan Irvine's GitHub Repo is present in the search results
	When we select it
	Then we are directed to the GitHub Repo wep page