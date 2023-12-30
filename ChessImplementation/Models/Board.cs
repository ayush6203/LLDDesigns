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

        public bool MovePiece()
        {
            return true;
        }
    }
}
