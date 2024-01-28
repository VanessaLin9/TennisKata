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

    private readonly string _firstPlayerName;
    private readonly string _secondPlayerName;

    public Tennis(string firstPlayerName, string secondPlayerName)
    {
        _firstPlayerName = firstPlayerName;
        _secondPlayerName = secondPlayerName;
    }


    public string Score()
    {
        if (IsScoreDifferent())
        {
            if (_FirstPlayerScoreTimes>3 || _SecondPlayerScoreTimes>3)
            {
                if (Math.Abs(_FirstPlayerScoreTimes - _SecondPlayerScoreTimes) == 1)
                {
                    var advPlayer = _FirstPlayerScoreTimes>_SecondPlayerScoreTimes?
                        _firstPlayerName:_secondPlayerName;
                    return $"{advPlayer} Adv";
                }
            }

            return LookupScore();
        }
        if (IsDeuce())
        {
            return Deuce();
        }
        return SamScore();
    }

    private bool IsScoreDifferent()
    {
        return _FirstPlayerScoreTimes != _SecondPlayerScoreTimes;
    }

    private string LookupScore()
    {
        return $"{_scoreLookup[_FirstPlayerScoreTimes]} {_scoreLookup[_SecondPlayerScoreTimes]}";
    }

    private bool IsDeuce()
    {
        return _FirstPlayerScoreTimes>=3;
    }

    private static string Deuce()
    {
        return "Deuce";
    }

    private string SamScore()
    {
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