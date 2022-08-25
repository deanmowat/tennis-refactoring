namespace Tennis
{
    class OnGoingScore : Score
    {
        private Player player1;
        private Player player2;
        public OnGoingScore(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public string AsText()
        {
            return GetScorePart(this.player1.CurrentPoints()) + "-" + GetScorePart(this.player2.CurrentPoints());
        }

        private static string GetScorePart(int playerPoints)
        {
            switch (playerPoints)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
            }

            throw new System.Exception("Attempted to show ongoing score but player points are not valid");
        }
    }
}