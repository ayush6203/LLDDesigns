using ChessImplementation.Enums;
using ChessImplementation.Interfaces;

namespace ChessImplementation.Models
{
    public class Piece
    {
        public Color Color { get; set; }
        public PieceType PieceType { get; set; }
        public IList<IMove> Moves { get; set; }
    }
}
