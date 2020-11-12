namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[][] Cells;
        public int Row { get; }
        public int Column { get; }

        public int GenerationCount { get; private set; }

        public Generation(Cell[][] cells)
        {
            Cells = cells;
            GenerationCount = 1;
            Row = cells.GetLength(0);
            Column = cells[0].Length;
        }
        
        public Generation GenerateNewGeneration()
        {
            GenerationCount++;
            return this;
        }
    }
}