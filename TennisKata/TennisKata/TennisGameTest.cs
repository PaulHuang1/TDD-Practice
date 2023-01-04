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

        [Test]
        public void A04_Forty_Love()
        {
            GivenPlayer1Score(3);
            ScoreShouldBe("Forty-Love");
        }

        [Test]
        public void A05_Love_Fifteen()
        {
            GivenPlayer2Score(1);
            ScoreShouldBe("Love-Fifteen");
        }

        [Test]
        public void A06_Love_Thirty()
        {
            GivenPlayer2Score(2);
            ScoreShouldBe("Love-Thirty");
        }

        [Test]
        public void A07_Love_Forty()
        {
            GivenPlayer2Score(3);
            ScoreShouldBe("Love-Forty");
        }

        private void GivenPlayer2Score(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _tennisGame.Player2Score();
            }
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