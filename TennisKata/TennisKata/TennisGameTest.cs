using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisGameTest
    {
        [Test]
        public void A01_LoveAll()
        {
            var expected = "Love-All";
            var tennisGame = new TennisGame();
            var actual = tennisGame.Score();
            Assert.AreEqual(actual, expected);
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            throw new System.NotImplementedException();
        }
    }
}