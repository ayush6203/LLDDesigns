using SnakeAndLadderImplementation.Interfaces;

namespace SnakeAndLadderImplementation.Models
{
    public class Board
    {
        private readonly IList<IJump> Snakes;
        private readonly IList<IJump> Ladders;
        private readonly int MinCell, MaxCell;
        private Queue<Player> playersQ;
        private readonly Dice dice;

        public Board(int n, IList<IJump> snakes, IList<IJump> ladders, IList<Player> players)
        {
            MinCell = 1;
            MaxCell = n * n;
            Snakes = snakes;
            Ladders = ladders;
            playersQ = new Queue<Player>(players);
            dice = new Dice();
        }
    
        //Register players : Do this if you want to add more players even after game starts, otherwise keep it inside the constructor itself.

        public void BeginGamePlay()
        {
            Console.WriteLine("Registered players");
            int playersCount = playersQ.Count;
            for(int i = 0; i < playersCount; i++)
            {
                Player playerForIntro = playersQ.Dequeue();
                Console.Write(playerForIntro.PlayerName + " |  ");
                playersQ.Enqueue(playerForIntro);
            }

            Console.WriteLine("Lets begin the game");
            Console.WriteLine();

            while(playersQ.Count > 1)
            {

            }

            Console.WriteLine("Game Over! And the winners are listed below");
        }
    }
}
