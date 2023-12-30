namespace ChessImplementation.Models
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Piece Piece { get; set; }

        public Cell(int x, int y, Piece piece)
        {
            X = x;
            Y = y;
            Piece = piece;
        }
    }
}
