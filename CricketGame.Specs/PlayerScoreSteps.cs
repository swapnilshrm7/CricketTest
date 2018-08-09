using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        private Cricket _player1;
        private Cricket _player2;
        [When(@"Player has started a game of cricket")]
        [Given(@"Player has started a new game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }

        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            //ScenarioContext.Current.Pending();
            _game.PlayerScore.Should().Be(score);
        }
        
        [When(@"Player scores a (.*)")]
        public void WhenPlayerScoresA(int runs)
        {
            _game.Score(runs);
            //ThenThePlayerScoreShouldIncreaseBy(runs);
        }
        
        [Then(@"the player score should increase by (.*)")]
        public void ThenThePlayerScoreShouldIncreaseBy(int runs)
        {
            _game.PlayerScore.Should().Be(runs);

        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int runs)
        {
            _game.PlayerScore = runs;
        }

        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
        }
        [Then(@"the player score should increase to (.*)")]
        public void ThenThePlayerScoreShouldIncreaseTo(int runs)
        {
            _game.PlayerScore.Should().Be(runs);
        }
        //second feature file's features here
        [Given(@"Player (.*) has started his innings")]
        public void GivenPlayerHasStartedHisInnings(int player)
        {
            if(player==1)
            {
                _player1 = new Cricket();
            }
            else if(player==2)
            {
                _player2 = new Cricket();
            }
        }

        [Given(@"Player (.*) scores (.*) runs")]
        public void GivenPlayerScoresRuns(int player, int runs)
        {
            if(player==1&&_player1.notout==true)
            {
                _player1.Score(runs);
            }
            else if(player==2 && _player2.notout == true)
            {
                _player2.Score(runs);
            }
        }

        [Given(@"player (.*) gets out")]
        public void GivenPlayerGetsOut(int player)
        {
            if(player==1 && _player1.notout == true)
            {
                _player1.notout = false;
            }
            else if(player==2 && _player2.notout == true)
                {
                _player2.notout = false;
            }
        }

        [When(@"Player (.*) inning ends")]
        public void WhenPlayerInningEnds(int player)
        {
            if(player==2 && _player1.notout == false && _player2.notout == false)
            {
             _player1.check(_player1.PlayerScore, _player2.PlayerScore);
            }
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(String result)
        {
            _player1.result.Should().Be(result);
        }

    }
}
