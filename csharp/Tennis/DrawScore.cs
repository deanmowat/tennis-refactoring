namespace Tennis
{
    class DrawScore : Score
    {
        private Player player1;
        private Player player2;
        public DrawScore(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public string AsText()
        {
            switch (this.player1.CurrentPoints())
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}