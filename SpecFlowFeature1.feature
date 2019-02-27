Feature: Start a Game
	Be able to enter number of players
	And enter number of holes
	And enter player names
	And start a game

Background:
	Given I am on the ReskyDeskTesking Web Application

@First Scenario
Scenario: S1: Create New Game Scorecard for 2 players and 9 holes
	Given the app works
	And I select 2 for the amount of players
	And I select 9 for the hole count
	And I enter Tmdqud for name 1
	And I enter Skdud for name 2
	When I press start game
	Then I should be on the PlayStage

@Second Scenario
Scenario: S2: Create New Game Scorecard for 1 player and 9 holes
	Given the app works
	And I select 1 for the amount of players
	And I select 9 for the hole count
	And I enter Black for name 1
	When I press start game
	Then I should be on the PlayStage

@Third Scenario
Scenario: S3: Create New Game Scorecard for 9 players and 9 holes
	Given the app works
	And I select 9 for the amount of players
	And I select 9 for the hole count
	And I enter Paul for name 1
	And I enter Shiv for name 2
	And I enter Monica for name 3
	And I enter Henry for name 4
	And I enter Nessa for name 5
	And I enter Zoren for name 6
	And I enter Neil for name 7
	And I enter Kayne for name 8
	And I enter Moron for name 9
	When I press start game
	Then I should be on the PlayStage

@Fourth Scenario
Scenario: S4: Create New Game Scorecard for 9 players and 18 holes
	Given the app works
	And I select 9 for the amount of players
	And I select 18 for the hole count
	And I enter Paul for name 1
	And I enter Shiv for name 2
	And I enter Monica for name 3
	And I enter Henry for name 4
	And I enter Nessa for name 5
	And I enter Zoren for name 6
	And I enter Neil for name 7
	And I enter Kayne for name 8
	And I enter Moron for name 9
	When I press start game
	Then I should be on the PlayStage
