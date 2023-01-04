namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreValue;

        public string Score()
        {
            if (_player1ScoreValue == 1)
            {
                return "Fifteen-Love";
            }
            if (_player1ScoreValue == 2)
            {
                return "Thirty-Love";
            }
            return "Love-All";
        }

        public void Player1Score()
        {
            _player1ScoreValue++;
        }
    }
}