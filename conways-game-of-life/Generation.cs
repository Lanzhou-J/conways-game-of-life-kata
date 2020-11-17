namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[][] Cells { get; set; }
        public int Row { get; }
        public int Column { get; }

        public int[][] LiveNeighboursCounts { get; }

        public int GenerationCount { get; private set; }
        
        public Cell CreateCellBasedOnCellState(Cell cell)
        {
            if (cell.State == State.Live)
            {
                return new Cell(State.Dead);
            }

            return new Cell(State.Live);

        }

        public Generation(Cell[][] cells)
        {
            Cells = cells;
            GenerationCount = 1;
            Row = cells.Length;
            Column = cells[0].Length;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }
        public Generation(int row, int column)
        {
            Cells = CreateDefaultCells(row, column);
            GenerationCount = 1;
            Row = row;
            Column = column;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }
        
        public Cell[][] CreateDefaultCells(int row, int column)
        {
            var cells = new Cell[row][];

           for (int i = 0; i < row; i++)
           {
               cells[i] = new Cell[3];
               for (int j = 0; j < column; j++)
               {
                   cells[i][j] = new Cell();
               }
           }
           return cells;
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
                cells[i] = new Cell[states.GetLength(1)];
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