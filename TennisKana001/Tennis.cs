using System.Collections.Generic;

namespace TennisKana001
{
    public class Tennis
    {
        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        private int _firstPlayerScoreTime;

        public string Score()
        {
            if (_firstPlayerScoreTime > 0) return $"{_scoreLookUp[_firstPlayerScoreTime]} Love";

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTime++;
        }
    }
}