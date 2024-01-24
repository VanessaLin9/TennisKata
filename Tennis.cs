using System.Reflection;

namespace TennisKata;

public class Tennis
{
    private int _FirstPlayerScoreTimes;

    private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
    {
        {1, "Fifteen"},
        {2, "Thirty"}
    };

    public string Score()
    {
        if(_FirstPlayerScoreTimes == 1 || _FirstPlayerScoreTimes == 2)
        {
            return $"{_scoreLookup[_FirstPlayerScoreTimes]} Love";
        }
        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _FirstPlayerScoreTimes++;
    }
}