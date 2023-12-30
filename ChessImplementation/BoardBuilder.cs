using ChessImplementation.Interfaces;
using ChessImplementation.Models;
using ChessImplementation.Moves;

namespace ChessImplementation
{
    public class BoardBuilder
    {
        private int boardId;
        private Cell[,] cells;
        public BoardBuilder Init (int boardId)
        {
            this.boardId = boardId;
            cells = new Cell[8, 8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    cells[i, j] = new Cell(i, j, null);
                }
            }

            return this;
        }

        public BoardBuilder InitPawns()
        {
            IList<IMove> pawnMoves = new List<IMove>();
            VerticalMove verticalMove = new VerticalMove();
            verticalMove.MovementRange = 1;
            InitialVerticalMove initialVerticalMove = new InitialVerticalMove();
            initialVerticalMove.MovementRange = 2;
            DiagonalMoveWithAttack diagonalMoveWithAttack = new DiagonalMoveWithAttack();
            diagonalMoveWithAttack.MovementRange = 1;

            pawnMoves.Add(verticalMove);
            pawnMoves.Add(initialVerticalMove);
            pawnMoves.Add(diagonalMoveWithAttack);
            for (int i = 0; i < 8; i++)
            {
                cells[1, i].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Pawn, Moves = pawnMoves };
                cells[6, i].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Pawn, Moves = pawnMoves };
            }
            return this;
        }

        public BoardBuilder InitRooks()
        {
            IList<IMove> rookMoves = new List<IMove>();
            HorizontalMove horizontalMove = new HorizontalMove();
            horizontalMove.MovementRange = 8;
            VerticalMove verticalMove = new VerticalMove();
            verticalMove.MovementRange = 8;

            rookMoves.Add(horizontalMove);
            rookMoves.Add(verticalMove);
            cells[0, 0].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Rook, Moves = rookMoves };
            cells[0, 7].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Rook, Moves = rookMoves };
            cells[7, 0].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Rook, Moves = rookMoves };
            cells[7, 7].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Rook, Moves = rookMoves };
            return this;
        }

        public BoardBuilder InitBishops()
        {
            IList<IMove> bishopMoves = new List<IMove>();
            DiagonalMove diagonalMove = new DiagonalMove();
            diagonalMove.MovementRange = 8;

            bishopMoves.Add(diagonalMove);
            cells[0, 2].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Bishop, Moves = bishopMoves };
            cells[0, 5].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Bishop, Moves = bishopMoves };
            cells[7, 2].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Bishop, Moves = bishopMoves };
            cells[7, 5].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Bishop, Moves = bishopMoves };
            return this;
        }

        public BoardBuilder InitKing()
        {
            IList<IMove> kingMoves = new List<IMove>();
            HorizontalMove horizontalMove = new HorizontalMove();
            horizontalMove.MovementRange = 1;
            VerticalMove verticalMove = new VerticalMove();
            verticalMove.MovementRange = 1;
            DiagonalMove diagonalMove = new DiagonalMove();
            diagonalMove.MovementRange = 1;

            kingMoves.Add(horizontalMove);
            kingMoves.Add(verticalMove);
            kingMoves.Add(diagonalMove);
            cells[0, 3].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.King, Moves = kingMoves };
            cells[7, 4].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.King, Moves = kingMoves };
            return this;
        }

        public BoardBuilder InitQueen()
        {
            IList<IMove> queenMoves = new List<IMove>();
            HorizontalMove horizontalMove = new HorizontalMove();
            horizontalMove.MovementRange = 8;
            VerticalMove verticalMove = new VerticalMove();
            verticalMove.MovementRange = 8;
            DiagonalMove diagonalMove = new DiagonalMove();
            diagonalMove.MovementRange = 8;

            queenMoves.Add(horizontalMove);
            queenMoves.Add(verticalMove);
            queenMoves.Add(diagonalMove);
            cells[0, 4].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Queen, Moves = queenMoves };
            cells[7, 3].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Queen, Moves = queenMoves };
            return this;
        }

        public BoardBuilder InitKnights()
        {
            IList<IMove> knightMoves = new List<IMove>();
            cells[0, 1].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Knight, Moves = knightMoves };
            cells[0, 6].Piece = new Piece() { Color = Enums.Color.White, PieceType = Enums.PieceType.Knight, Moves = knightMoves };
            cells[7, 1].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Knight, Moves = knightMoves };
            cells[7, 6].Piece = new Piece() { Color = Enums.Color.Black, PieceType = Enums.PieceType.Knight, Moves = knightMoves };
            return this;
        }

        public Board InitBoard()
        {
            return new Board(boardId, cells);
        }
    }
}
