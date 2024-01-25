using System.Reflection;

namespace TennisKata;

public class Tennis
{
    private int _FirstPlayerScoreTimes;
    private int _SecondPlayerScoreTimes;

    private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
    {
        {1, "Fifteen"},
        {2, "Thirty"},
        {3, "Forty"}
    };


    public string Score()
    {
        if(_FirstPlayerScoreTimes > 0)
        {
            return $"{_scoreLookup[_FirstPlayerScoreTimes]} Love";
        }
        if (_SecondPlayerScoreTimes==1)
        {
            return "Love Fifteen";
        }
        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _FirstPlayerScoreTimes++;
    }

    public void SecondPlayerScore()
    {
        _SecondPlayerScoreTimes++;
    }
}