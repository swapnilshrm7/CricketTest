Feature: CricketMatch
	In order to enjoy a game of cricket
	As a player
	I want to be told who won the match

@mytag
Scenario: Both player's score is zero when game starts
	Given Player 1 has started his innings
	And Player 1 scores 3 runs
	And Player 1 scores 5 runs
	And Player 1 scores 6 runs
	And Player 1 scores 7 runs
	And Player 1 scores 1 runs
	And player 1 gets out
	And Player 2 has started his innings
	And Player 2 scores 3 runs
	And Player 2 scores 5 runs
	And Player 2 scores 6 runs
	And Player 2 scores 7 runs
	And Player 2 scores 2 runs
	And player 2 gets out
	When Player 2 inning ends
	Then the result should be player 2 win

	Scenario: Both player's score is zero when new game starts
	Given Player 1 has started his innings
	And Player 1 scores 3 runs
	And Player 1 scores 5 runs
	And Player 1 scores 6 runs
	And Player 1 scores 7 runs
	And Player 1 scores 1 runs
	And player 1 gets out
	And Player 2 has started his innings
	And Player 2 scores 3 runs
	And Player 2 scores 5 runs
	And Player 2 scores 6 runs
	And Player 2 scores 7 runs
	And Player 2 scores 0 runs
	And player 2 gets out
	When Player 2 inning ends
	Then the result should be player 1 win

	Scenario: Both player's score is zero when a new game starts
	Given Player 1 has started his innings
	And Player 1 scores 3 runs
	And Player 1 scores 5 runs
	And Player 1 scores 6 runs
	And Player 1 scores 7 runs
	And Player 1 scores 1 runs
	And player 1 gets out
	And Player 2 has started his innings
	And Player 2 scores 3 runs
	And Player 2 scores 5 runs
	And Player 2 scores 6 runs
	And Player 2 scores 7 runs
	And Player 2 scores 1 runs
	And player 2 gets out
	When Player 2 inning ends
	Then the result should be tie
