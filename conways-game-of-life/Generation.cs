namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[][] Cells;
        public int Row { get; }
        public int Column { get; }

        public int[][] LiveNeighboursCounts { get; }

        public int GenerationCount { get; private set; }

        public Generation(Cell[][] cells)
        {
            Cells = cells;
            GenerationCount = 1;
            Row = cells.Length;
            Column = cells[0].Length;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }
        
        public Generation(Cell[][] cells, int generationCount)
        {
            Cells = cells;
            GenerationCount = generationCount;
            Row = cells.Length;
            Column = cells[0].Length;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }

        public State GetCellState(int x, int y)
        {
            var cell = Cells[x][y];
            var state = cell.State;
            return state;
        }

        // public int[][] GetLiveNeighboursCounts()
        // {
        //     
        // }
    }
}