Feature: SpecFlowFeature1
	In order to be a disc golf pro
	as a disc golf amateur
	I want to be able to keep track of score

@First Scenario
Scenario: Create New Game Scorecard for 2 players and 9 holes
	Given I am on the ReskyDeskTesking Web Application
	And I select 2 for the amount of players
	And I select 9 for the hole count
	And I enter "name1"
	And I also enter "name2"
	When I press start game
	Then I should be on the PlayStage
