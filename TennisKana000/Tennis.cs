using System.Collections.Generic;

namespace TennisKana000
{
    public class Tennis
    {
        private int _firstPlayerScoreTime;

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        public string Score()
        {
            if (_firstPlayerScoreTime > 0)
            {
                return $"{_scoreLookUp[_firstPlayerScoreTime]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTime++;
        }
    }
}