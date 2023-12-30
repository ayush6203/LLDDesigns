using ChessImplementation.Models;

namespace ChessImplementation.Interfaces
{
    public interface IMove
    {
        public int MovementRange { get; set; }
        public bool CanMove(Cell src, Cell dest);
    }
}
