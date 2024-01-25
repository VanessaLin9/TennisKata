using System.Reflection;

namespace TennisKata;

public class Tennis
{
    private int _FirstPlayerScoreTimes;
    private int _SecondPlayerScoreTimes;

    private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
    {
        { 0, "Love" },
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" }
    };


    public string Score()
    {
        if (_FirstPlayerScoreTimes != _SecondPlayerScoreTimes)
        {
            return $"{_scoreLookup[_FirstPlayerScoreTimes]} {_scoreLookup[_SecondPlayerScoreTimes]}";
        }
        return $"{_scoreLookup[_FirstPlayerScoreTimes]} All";
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