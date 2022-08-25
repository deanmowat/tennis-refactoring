namespace Tennis 
{
   public class Player 
   {
       private string playerName;
       private int currentPoints;
       private int gameWins;
       
       public Player(string playerName)
       {
          this.playerName = playerName;
          this.currentPoints = 0; 
          this.gameWins = 0;
       }

       public bool HasAdvantage(Player otherPlayer)
       {
           return this.currentPoints >= 4 && (this.currentPoints - otherPlayer.currentPoints) == 1;
       }
       
       public bool HasWon(Player otherPlayer)
       {
           return this.currentPoints >= 4 && (this.currentPoints - otherPlayer.currentPoints) >= 2;
       }
       
      public bool IsDrawing(Player otherPlayer)
      {
          return this.currentPoints == otherPlayer.currentPoints;
      } 
      
      public void AddPoint()
      {
          this.currentPoints += 1;
      }
      
      public void ResetPoints()
      {
          this.currentPoints = 0;
      }
      
      public int CurrentPoints()
      {
          return this.currentPoints;
      }
      
      public void AddGameWin()
      {
          this.gameWins += 1;
      }
       
      public int GetGameWins()
      {
          return this.gameWins;
      }
      
      public string GetPlayerName()
      {
          return this.playerName;
      }

   } 
}