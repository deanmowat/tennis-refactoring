namespace Tennis 
{
    public class ScoreDecider
    {
        private Player player1;
        private Player player2;
        public ScoreDecider(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        
        public Score GetScore()
        {
            if (OnePlayerHasWon()) return new WonScore(player1, player2);

            if (OnePlayerHasAdvantage()) return new AdvantageScore(player1, player2);

            if (ScoreIsDrawn()) return new DrawScore(player1, player2);

            return new OnGoingScore(player1, player2);
        }

        private bool OnePlayerHasAdvantage()
        {
            return this.player1.HasAdvantage(this.player2) || this.player2.HasAdvantage(this.player1);
        }

        private bool OnePlayerHasWon()
        {
            return this.player1.HasWon(this.player2) || this.player2.HasWon(this.player1);
        }

        private bool ScoreIsDrawn()
        {
            return this.player1.IsDrawing(this.player2);
        }

    }
}