using ChessImplementation.Enums;

namespace ChessImplementation.Models
{
    public class Board
    {
        private readonly int boardId;
        private readonly Cell[,] boardCells;

        public Board(int id, Cell[,] boardCells)
        {
            boardId = id;
            this.boardCells = boardCells;
        }

        public bool MovePiece(Color pieceColor, int srcX, int srcY, int destX, int destY)
        {
            Cell sourceCell = boardCells[srcX, srcY];
            Cell destinationCell = boardCells[destX, destY];

            if (sourceCell.Piece is null)
                return false; // throw empty cell exception, there should be a piece.

            if (sourceCell.Piece.Color != pieceColor)
                return false; // throw wrong piece selection error, player should use it's own piece.

            if (destinationCell.Piece.Color == pieceColor)
                return false; // Cell is already occuped by same color piece.

            var allValidMoves = sourceCell.Piece.Moves;
            bool canMove = true;
            foreach (var validMoves in allValidMoves)
                canMove = canMove && validMoves.CanMove(sourceCell, destinationCell);

            if (canMove)
                destinationCell.Piece = sourceCell.Piece;       // if destinatin cell contains some piece, remove it and store it in some other list (track lost pieces)

            return canMove;
        }
    }
}
