namespace Tennis
{
    class WonScore : Score
    {
        private Player player1;
        private Player player2;
        public WonScore(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public string AsText()
        {
            return "Win for " + GetWinnersName();
        }
        
        private string GetWinnersName()
        {
            if (this.player1.HasWon(this.player2)) return this.player1.GetPlayerName();
            if (this.player2.HasWon(this.player1)) return this.player2.GetPlayerName();

            throw new System.Exception("Attempted to show won score but no player has won");
        }
    }
}