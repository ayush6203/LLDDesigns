using ChessImplementation.Enums;

namespace ChessImplementation.Models
{
    public class Player
    {
        public Player(int id, string name, int rank, Color color)
        {
            Id = id;
            Name = name;
            Rank = rank;
            Color = color;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public Color Color { get; set; }
    }
}
