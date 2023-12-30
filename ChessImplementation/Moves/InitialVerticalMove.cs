using ChessImplementation.Interfaces;
using ChessImplementation.Models;

namespace ChessImplementation.Moves
{
    public class InitialVerticalMove : IMove
    {
        public int MovementRange { get; set; }

        public int CanMove(Cell src, Cell dest)
        {
            throw new NotImplementedException();
        }
    }
}
