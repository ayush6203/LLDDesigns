using SnakeAndLadderImplementation.Interfaces;

namespace SnakeAndLadderImplementation.Models
{
    public class Snake : IJump
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
