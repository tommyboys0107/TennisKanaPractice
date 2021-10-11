using NUnit.Framework;

namespace TennisKana000
{
    [TestFixture]
    public class TennisTests
    {
        [SetUp]
        public void Setup()
        {
            _tennis = new Tennis();
        }

        private Tennis _tennis;

        [Test]
        public void LoveAll()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void FifteenLove()
        {
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (var i = 0; i < times; i++) _tennis.FirstPlayerScore();
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}