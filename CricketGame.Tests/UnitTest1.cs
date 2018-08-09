using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Cricket game = new Cricket();
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);
        }
    }
}
