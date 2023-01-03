using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisGameTest
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void @Setup()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void A01_LoveAll()
        {
            ScoreShouldBe("Love-All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            _tennisGame.Player1Score();
            ScoreShouldBe("Fifteen-Love");
        }

        private void ScoreShouldBe(string expected)
        {
            var actual = _tennisGame.Score();
            Assert.AreEqual(actual, expected);
        }
    }
}