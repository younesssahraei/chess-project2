public class Chessboard
{
    private ChessPiece[,] board;  // آرایه دوبعدی برای نگهداری مهره ها

    public Chessboard()
    {
        board = new ChessPiece[8, 8];
    }

    public void InitializeBoard()
    {
        // قرار دادن مهره های پیاده در ردیف های دوم و هفتم
        for (int i = 0; i < 8; i++)
        {
            board[1, i] = new Pawn(PieceColor.White);
            board[6, i] = new Pawn(PieceColor.Black);
        }

        // قرار دادن مهره های دیگر در موقعیت های مورد نظر
        board[0, 0] = new Rook(PieceColor.White);
        board[0, 7] = new Rook(PieceColor.White);
        board[7, 0] = new Rook(PieceColor.Black);
        board[7, 7] = new Rook(PieceColor.Black);


        board[0, 1] =new Knight(PieceColor.White);
        board[0, 6] = new Knight(PieceColor.White);
        board[7, 1] = new Knight(PieceColor.Black);
        board[7, 6] = new Knight(PieceColor.Black);


        board[0, 2] = new Bishop(PieceColor.White);
        board[0, 5] = new Bishop(PieceColor.White);
        board[7, 2] = new Bishop(PieceColor.Black);
        board[7, 5] = new Bishop(PieceColor.Black);

        board[0, 3] = new Queen(PieceColor.White);
        board[7, 3] = new Queen(PieceColor.Black);

        board[0, 4] = new King(PieceColor.White);
        board[7, 4] = new King(PieceColor.Black);
        // ادامه برای سایر مهره ها مانند فیل و شاه و ...
    }

    public void PrintBoard()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (board[row, col] != null)
                    Console.Write(board[row, col].GetPieceSymbol());
                else
                    Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}

public abstract class ChessPiece
{
    public PieceColor Color { get; private set; }

    public ChessPiece(PieceColor color)
    {
        Color = color;

    }

    public abstract string GetPieceSymbol();
}

public class Pawn : ChessPiece
{
    public Pawn(PieceColor color) : base(color) { }

    public override string GetPieceSymbol()
    {
        return "P";  // نماد پیاده
    }
}

public class Rook : ChessPiece
{
    public Rook(PieceColor color) : base(color) { }
    public override string GetPieceSymbol()
    {
        return "R";
    }
}

public class Knight : ChessPiece
{
    public Knight(PieceColor color) : base(color) { }
    public override string GetPieceSymbol()
    {
        return "K";
    }
}

public class Bishop : ChessPiece
{
    public Bishop(PieceColor color) : base(color) { }
    public override string GetPieceSymbol()
    {
        return "B";
    }
}

public class Queen : ChessPiece
{
    public Queen(PieceColor color) : base(color) { }
    public override string GetPieceSymbol()
    {
        return "Q";
    }
}

public class King : ChessPiece
{
    public King(PieceColor color) : base(color) { }
    public override string GetPieceSymbol()
    {
        return "K";
    }

}
// تعریف کلاس های دیگر برای شاه، فیل و ...




public class PieceColor
{
    public static PieceColor White { get; internal set; }

    public static PieceColor Black { get; internal set; }
}
