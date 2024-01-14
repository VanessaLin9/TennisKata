using NUnit.Framework;

namespace TennisKata;

[TestFixture]
public class TennisTests
{
    [SetUp]
    public void SetUp(){
        _tennis = new Tennis();
    }
    
    private Tennis _tennis;

    [Test]
    public void Love_All()
    {
        Assert.AreEqual("Love All", _tennis.Score());
    }
}