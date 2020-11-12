namespace conways_game_of_life
{
    public class World
    {
        public Cell[,] Cells;
        public int Row { get; }
        public int Column { get; }

        public World(Cell[,] cells)
        {
            Cells = cells;
            Row = cells.GetLength(0);
            Column = cells.GetLength(1);
        }
    }
}