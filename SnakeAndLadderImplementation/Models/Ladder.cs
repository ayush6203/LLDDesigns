using SnakeAndLadderImplementation.Interfaces;

namespace SnakeAndLadderImplementation.Models
{
    public class Ladder : IJump
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
