using NUnit.Framework;

namespace TennisKata;

[TestFixture]
public class TennisTests
{
    [SetUp]
    public void SetUp()
    {
        _tennis = new Tennis();
    }

    private Tennis _tennis;

    [Test]
    public void Love_All()
    {
        ScoreShouldBe("Love All");
    }

    [Test]
    public void Fifteen_Love()
    {
        _tennis.FirstPlayerScore();
        ScoreShouldBe("Fifteen Love");
    }

    private void ScoreShouldBe(string expected)
    {
        Assert.AreEqual(expected, _tennis.Score());
    }
}