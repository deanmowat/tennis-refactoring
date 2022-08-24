namespace Tennis
{
    class AdvantageScore : Score
    {
        private Player player1;
        private Player player2;
        public AdvantageScore(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public string AsText()
        {
            return "Advantage " + GetPlayerWithAdvantagesName();
        }
        
        private string GetPlayerWithAdvantagesName()
        {
            if (this.player1.HasAdvantage(this.player2)) return this.player1.GetPlayerName();
            if (this.player2.HasAdvantage(this.player1)) return this.player2.GetPlayerName();
            
            throw new System.Exception("Attempted to show advantage score but no player has advantage");
        }
    }
}