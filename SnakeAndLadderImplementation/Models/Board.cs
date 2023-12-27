using SnakeAndLadderImplementation.Interfaces;

namespace SnakeAndLadderImplementation.Models
{
    public class Board
    {
        private readonly IList<IJump> Snakes;
        private readonly IList<IJump> Ladders;
        private readonly int MaxCell, maxSnakes, maxLadders;
        private Queue<Player> playersQ;
        private readonly Dice dice;
        private HashSet<(int start, int end)> hs;

        public Board(int n, int snakes, int ladders, IList<Player> players)
        {
            MaxCell = n * n;
            maxSnakes = snakes;
            maxLadders = ladders;
            playersQ = new Queue<Player>(players);
            dice = new Dice();
            hs = new HashSet<(int start, int end)>();
            Snakes = new List<IJump>();
            Ladders = new List<IJump>();
            BuildSnakeandLadders();
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
                Player currPlayer = playersQ.Dequeue();
                int diceResult = dice.Roll();
                int playersNewPosition = diceResult + currPlayer.Position;
                Console.WriteLine(currPlayer.PlayerName + " rolled the dice => " + diceResult);
                var res = Snakes.FirstOrDefault(s => s.Start == playersNewPosition);
                if(res != null)
                {
                    Console.WriteLine(currPlayer.PlayerName + " bitten by snake");
                    playersNewPosition = res.End;
                    goto x;
                }

                var res1 = Ladders.FirstOrDefault(s => s.Start == playersNewPosition);
                if (res != null)
                {
                    Console.WriteLine(currPlayer.PlayerName + " got the ladder");
                    playersNewPosition = res.End;
                }

                x:
                if (playersNewPosition > MaxCell)
                    playersNewPosition = currPlayer.Position;

                currPlayer.MovePlayer(playersNewPosition);
                Console.WriteLine(currPlayer.PlayerName + " is now at " + currPlayer.Position);

                if(currPlayer.Position == MaxCell)
                {
                    Console.WriteLine(currPlayer.PlayerName + " won the game");
                    Console.WriteLine();
                    continue;
                }

                playersQ.Enqueue(currPlayer);
                Console.WriteLine();
            }

            Console.WriteLine("Game Over! And the winners are listed below");
        }

        private void BuildSnakeandLadders()
        {
            int i = 0;
            var r = new Random();
            while(i < maxSnakes)
            {
                int start = r.Next(1, MaxCell);
                int end = r.Next(1, start);

                if (hs.Contains((start, end)) || hs.Contains((end, start)))
                    continue;

                ++i;
                Snakes.Add(new Snake() { Start = start, End = end });
                hs.Add((start, end));
            }

            int j = 0;
            while (j < maxLadders)
            {
                int start = r.Next(1, MaxCell);
                int end = r.Next(start + 1, MaxCell);

                if (hs.Contains((start, end)) || hs.Contains((end, start)))
                    continue;

                ++j;
                Ladders.Add(new Ladder() { Start = start, End = end });
                hs.Add((start, end));
            }
        }
    }
}
