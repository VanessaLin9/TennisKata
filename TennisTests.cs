using NUnit.Framework;

namespace TennisKata;

[TestFixture]
public class TennisTests
{
    [Test]
    public void Love_All()
    {
        var tennis = new Tennis();
        Assert.AreEqual("Love All", tennis.Score());
    }
}