namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[,] Cells;
        public int Row { get; }
        public int Column { get; }

        public int GenerationCount { get; }

        public Generation(Cell[,] cells)
        {
            Cells = cells;
            GenerationCount = 1;
            Row = cells.GetLength(0);
            Column = cells.GetLength(1);
        }
    }
}