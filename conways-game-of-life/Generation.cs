using System.Collections.Generic;
using System.Reflection;

namespace conways_game_of_life
{
    public class Generation
    {
        public Cell[][] Cells { get; set; }
        private int Row { get; }
        private int Column { get; }

        private int GenerationCount { get; set; }

        private static int LatestGenerationCount { get; set; }

        public Generation(Cell[][] cells)
        {
            Cells = cells;
            GenerationCount = LatestGenerationCount + 1;
            Row = cells.Length;
            Column = cells[0].Length;
            LatestGenerationCount = GenerationCount;
        }
        public Generation(int row, int column)
        {
            Cells = CreateDefaultCells(row, column);
            GenerationCount = LatestGenerationCount + 1;
            Row = row;
            Column = column;
            LatestGenerationCount = GenerationCount;
        }

        private Cell[][] CreateDefaultCells(int row, int column)
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

        public Generation(State[][] states, int generationCount)
        {
            Cells = CreateCells(states);
            GenerationCount = generationCount;
            Row = Cells.Length;
            Column = Cells[0].Length;
            LatestGenerationCount = GenerationCount;
        }

        public State GetCellState(int x, int y)
        {
            var cell = Cells[x][y];
            var state = cell.State;
            return state;
        }

        public List<Cell> GetNeighbours()
        {
            return new List<Cell>();
        }

        public List<Cell> GetNeighbours(Cell cell)
        {
            var neighbours = new List<Cell>();
            if (GenerationSizeIsSmall())
            {
                AddAllTheRestOfCellsToNeighbours(cell, neighbours);
            }
            else
            {
                GetNeighboursFromA3Times3AreaAroundTheCell(cell, neighbours);
            }
            return neighbours;
        }

        private void GetNeighboursFromA3Times3AreaAroundTheCell(Cell cell, List<Cell> neighbours)
        {
            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    if (CellLocationIsInTheCenter(i, j)) continue;
                    var neighbourX = GetNeighbourX(cell, i);
                    var neighbourY = GetNeighbourY(cell, j);
                    var neighbour = Cells[neighbourX][neighbourY];
                    neighbours.Add(neighbour);
                }
            }
        }

        private static bool CellLocationIsInTheCenter(int i, int j)
        {
            return i == 0 && j == 0;
        }

        private bool GenerationSizeIsSmall()
        {
            return Row <= 2 && Column <= 2;
        }

        private int GetNeighbourY(Cell cell, int j)
        {
            var neighbourY = cell.Y + j;
            if (neighbourY < 0)
            {
                neighbourY = Column - 1;
            }
            else if (neighbourY > Column - 1)
            {
                neighbourY = 0;
            }

            return neighbourY;
        }

        private int GetNeighbourX(Cell cell, int i)
        {
            var neighbourX = cell.X + i;
            if (neighbourX < 0)
            {
                neighbourX = Row - 1;
            }
            else if (neighbourX > Row - 1)
            {
                neighbourX = 0;
            }

            return neighbourX;
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