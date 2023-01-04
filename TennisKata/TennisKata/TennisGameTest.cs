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
            GivenPlayer1Score(1);
            ScoreShouldBe("Fifteen-Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            GivenPlayer1Score(2);
            ScoreShouldBe("Thirty-Love");
        }

        private void GivenPlayer1Score(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _tennisGame.Player1Score();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            var actual = _tennisGame.Score();
            Assert.AreEqual(actual, expected);
        }
    }
}