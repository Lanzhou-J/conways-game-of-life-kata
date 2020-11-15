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
        
        public Generation(State[][] states)
        {
            Cells = CreateCells(states);
            GenerationCount = 1;
            Row = Cells.Length;
            Column = Cells[0].Length;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }

        private Cell[][] CreateCells(State[][] states)
        {
            var cells = new Cell[states.GetLength(0)][];
            for (int i = 0; i < states.GetLength(0); i++)
            {
                for (int j = 0; j < states.GetLength(1); j++)
                {
                    cells[i][j] = new Cell(states[i][j]);
                }
            }

            return cells;
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