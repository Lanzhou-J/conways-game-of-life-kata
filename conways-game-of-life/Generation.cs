using System.Collections.Generic;
using System.Reflection;

namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[][] Cells { get; set; }
        public int Row { get; }
        public int Column { get; }

        public int[][] LiveNeighboursCounts { get; }

        public int GenerationCount { get; private set; }

        public static int LatestGenerationCount { get; private set; }

        // public Cell CreateCellBasedOnCellState(Cell cell)
        // {
        //     if (cell.State == State.Live)
        //     {
        //         return new Cell(State.Dead);
        //     }
        //     return new Cell(State.Live);
        // }

        public Generation(Cell[][] cells)
        {
            Cells = cells;
            GenerationCount = LatestGenerationCount + 1;
            Row = cells.Length;
            Column = cells[0].Length;
            LatestGenerationCount = GenerationCount;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }
        public Generation(int row, int column)
        {
            Cells = CreateDefaultCells(row, column);
            GenerationCount = LatestGenerationCount + 1;
            Row = row;
            Column = column;
            LatestGenerationCount = GenerationCount;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }
        
        public Cell[][] CreateDefaultCells(int row, int column)
        {
            var cells = new Cell[row][];

           for (int i = 0; i < row; i++)
           {
               cells[i] = new Cell[column];
               for (int j = 0; j < column; j++)
               {
                   cells[i][j] = new Cell(i,j);
               }
           }
           return cells;
        }
        public Generation(State[][] states)
        {
            Cells = CreateCells(states);
            GenerationCount = LatestGenerationCount + 1;
            Row = Cells.Length;
            Column = Cells[0].Length;
            LatestGenerationCount = GenerationCount;
            // LiveNeighboursCounts = GetLiveNeighboursCounts();
        }

        private Cell[][] CreateCells(State[][] states)
        {
            var row = states.GetLength(0);
            var column = states[0].Length;
            var cells = new Cell[row][];
            for (int i = 0; i < row; i++)
            {
                cells[i] = new Cell[column];
                for (int j = 0; j < column; j++)
                {
                    cells[i][j] = new Cell(states[i][j], i, j);
                }
            }

            return cells;
        }

        // public Generation(Cell[][] cells, int generationCount)
        // {
        //     Cells = cells;
        //     GenerationCount = generationCount;
        //     LatestGenerationCount = generationCount;
        //     Row = cells.Length;
        //     Column = cells[0].Length;
        //     // LiveNeighboursCounts = GetLiveNeighboursCounts();
        // }
        
        public Generation(State[][] states, int generationCount)
        {
            Cells = CreateCells(states);
            GenerationCount = generationCount;
            Row = Cells.Length;
            Column = Cells[0].Length;
            LatestGenerationCount = GenerationCount;
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

        public List<Cell> GetNeighbours()
        {
            return new List<Cell>();
        }

        public List<Cell> GetNeighbours(Cell cell)
        {
            var neighbours = new List<Cell>();
            if (Row<=3 && Column<=3)
            {
                AddAllTheRestOfCellsToNeighbours(cell, neighbours);
            }
            else
            {
                for (var i = -1; i <= 1; i++)
                {
                    for (var j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0) continue;
                        var neighbourX = cell.X + i;
                        var neighbourY = cell.Y + j;

                        if (neighbourY < 0)
                        {
                            neighbourY = Column - 1;
                        }

                        if (neighbourX < 0)
                        {
                            neighbourX = Row - 1;
                        }

                        var neighbour = Cells[neighbourX][neighbourY];
                            
                        neighbours.Add(neighbour);
                    }
                }
            }
            return neighbours;
        }

        private bool IsOnBorder(Cell cell)
        {
            return (cell.X == 0 || cell.Y == 0 || cell.X == Row - 1 || cell.Y == Column - 1);
        }

        private void AddAllTheRestOfCellsToNeighbours(Cell cell, List<Cell> neighbours)
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (i != cell.X || j != cell.Y)
                    {
                        neighbours.Add(Cells[i][j]);
                    }
                }
            }
        }

        public Cell GetCell(int x, int y)
        {
            return Cells[x][y];
        }
    }
}