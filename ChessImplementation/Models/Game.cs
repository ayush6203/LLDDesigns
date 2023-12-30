namespace ChessImplementation.Models
{
    public class Game
    {
        private IList<Player> players;
        private int playerTurn;
        private Board board;

        public void InitGame()
        {
            //Onboard the players
            players = new List<Player>();
            players.Add(new Player(1, "Ayush", 234, Enums.Color.White));
            players.Add(new Player(2, "Piyush", 127, Enums.Color.Black));
            playerTurn = players[0].Id;     // By default white piece will start first.

            //Init Board
            board = new BoardBuilder().Init(1).InitPawns().InitRooks().InitKnights().InitBishops().InitKing().InitQueen().InitBoard();
            
        }

        public void PlayerEvent(int playerId, int srcX, int srcY, int destX, int destY)
        {
            if (playerId != playerTurn)
                return;     // throw exception show msg to user that its not your turn.


        }
    }
}
