namespace conways_game_of_life
{
    public class Board:IBoard
    {
        private Cell[,] _squares;

        public Board(int row, int column)
        {
            Row = row;
            Column = column;
            CreateBoard();
        }
        
        private void CreateBoard()
        {
            _squares = new Cell[Row, Column];
            for (var x = 0; x < Row; x++)
            {
                for (var y = 0; y < Column; y++)
                {
                    _squares[x, y] = new Cell();
                }
            }
        }

        public int Row { get; }
        public int Column { get; }

        public Cell GetCell(int x, int y)
        {
            return _squares[x, y];
        }
    }
}