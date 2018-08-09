Feature: PlayerScore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: Player1 score is set to zero when game starts
	Given Player has started a new game of cricket
	When Player scores a 4
	Then the player score should increase to 4

Scenario: Player1 should be able to score runs multiple times
	Given Player has started a new game of cricket
	Given Player has scored 4 runs
	When Player scores 3 runs
	Then the player score should increase to 7

	Scenario: Player1 should be able to score runs third time
	Given Player has started a new game of cricket
	Given Player has scored 7 runs
	When Player scores 3 runs
	Then the player score should increase to 10

	Scenario: Player1 should be able to score runs fourth time
	Given Player has started a new game of cricket
	Given Player has scored 10 runs
	When Player scores 3 runs
	Then the player score should increase to 13

	Scenario: Player1 should be able to score runs fifth time
	Given Player has started a new game of cricket
	Given Player has scored 13 runs
	When Player scores 3 runs
	Then the player score should increase to 16