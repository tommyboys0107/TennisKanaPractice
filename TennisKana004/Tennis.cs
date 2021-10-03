using System.Collections.Generic;

namespace TennisKana004
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        public string Score()
        {
            if (_firstPlayerScoreTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}