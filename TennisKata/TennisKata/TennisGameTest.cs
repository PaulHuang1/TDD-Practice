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

        private void ScoreShouldBe(string expected)
        {
            var actual = _tennisGame.Score();
            Assert.AreEqual(actual, expected);
        }
    }
}