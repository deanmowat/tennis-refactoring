namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private Player player1;
        private Player player2;
        private ScoreDecider scoreDecider;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1 =  new Player(player1Name);
            this.player2 = new Player(player2Name);
            this.scoreDecider = new ScoreDecider(player1, player2);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this.player1.GetPlayerName()) this.player1.AddPoint();
            if (playerName == this.player2.GetPlayerName()) this.player2.AddPoint();
        }
        public string GetScore()
        {
            var score = this.scoreDecider.GetScore();
            var scoreText = score.AsText();
            
            if (GameHasBeenWon(score)) CompleteGame();

            return scoreText;
        }

        private bool GameHasBeenWon(Score score)
        {
            return typeof(WonScore) == score.GetType();
        }
        private void CompleteGame()
        {
            if (this.player1.HasWon(this.player2)) this.player1.AddGameWin();
            if (this.player2.HasWon(this.player1)) this.player2.AddGameWin();

            this.player1.ResetPoints();
            this.player2.ResetPoints();
        }

        public int GetPlayer1Wins()
        {
            return this.player1.GetGameWins();
        }
        
        public int GetPlayer2Wins()
        {
            return this.player2.GetGameWins();
        }
    }
}

