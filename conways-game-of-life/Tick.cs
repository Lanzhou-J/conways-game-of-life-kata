using System.Collections.Generic;
using System.Linq;

namespace conways_game_of_life
{
    public static class Tick
    {
        public static void Evolve(int[][] input)
        {
            var rowLength = input.Length;
            var columnLength = input[0].Length;
            List<int> liveCellNumbers = new List<int>();

            for (var i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    var neighbours = GetNeighbours(input, i, j);
                    var liveCells = neighbours.Count(item => item == 1);
                    liveCellNumbers.Add(liveCells);
                }
            }

            var index = 0;
            for (var i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if ( input[i][j]==1)
                    {
                        if (liveCellNumbers[index] > 3)
                        {
                            input[i][j] = 0;
                        }else if (liveCellNumbers[index] < 2)
                        {
                            input[i][j] = 0;
                        }
                    }
                    else
                    {
                        if (liveCellNumbers[index]==3)
                        {
                            input[i][j] = 1;
                        }
                    }

                    index++;
                }
            }
        }
        
        public static int[] GetNeighbours(int[][] input, int i, int j)
        {
            var rowLength = input.Length;
            var columnLength = input[0].Length;
            var neighbours = new int[8];

            if (i == 0)
            {
                if (j == 0)
                {
                    neighbours = new[]
                    {
                        input[i][j+1], input[i+1][j], input[i+1][j+1], input[rowLength-1][columnLength-1], input[rowLength-1][j], input[rowLength-1][j+1], input[i][columnLength-1], input[i+1][columnLength-1] 
                    };
                    
                }
                else if (j == columnLength - 1)
                {
                    neighbours = new[]
                    {
                        input[0][columnLength-2], input[1][columnLength-2], input[1][columnLength-1], input[rowLength-1][columnLength-2], input[rowLength-1][columnLength-1], input[rowLength-1][0], input[0][0], input[1][0]
                    };
                    
                }
                else
                {
                    neighbours = new[]
                    {
                        input[0][j-1], input[0][j+1], input[1][j-1], input[1][j], input[1][j+1], input[rowLength-1][j-1], input[rowLength-1][j], input[rowLength-1][j+1]
                    };
                }
            }else if (i == rowLength - 1)
            {
                if (j == 0)
                {
                    neighbours = new[]
                    {
                        input[rowLength-2][0], input[rowLength-2][1], input[rowLength-1][1],input[0][j], input[0][j+1], input[0][columnLength-1], input[rowLength-1][columnLength-1], input[rowLength-2][columnLength-1]
                    };

                }
                else if (j == columnLength - 1)
                {
                    neighbours = new[]
                    {
                        input[i-1][j-1], input[i-1][j], input[i][j-1],input[0][j-1], input[0][j], input[0][0], input[rowLength-1][0], input[rowLength-2][0]
                    };
                }
                else
                {
                    neighbours = new[]
                    {
                        input[i-1][j-1], input[i-1][j], input[i-1][j+1],input[i][j-1], input[i][j+1], input[0][j-1], input[0][j], input[0][j+1]
                    };
                }
                
            }
            else
            {
                if (j == 0)
                {
                    neighbours = new[]
                    {
                        input[i - 1][j], input[i - 1][j + 1], input[i][j + 1], input[i + 1][j], input[i + 1][j + 1],
                        input[i - 1][columnLength - 1], input[i][columnLength - 1], input[i + 1][columnLength - 1]
                    };
                }
                else if (j == columnLength - 1)
                {
                    neighbours = new[]
                    {
                        input[i - 1][j - 1], input[i - 1][j], input[i][j - 1], input[i + 1][j - 1], input[i + 1][j], input[i - 1][0],
                        input[i][0], input[i + 1][0]
                    };
                }
                else
                {
                    neighbours = new[]
                    {
                        input[i - 1][j - 1], input[i - 1][j], input[i - 1][j + 1], input[i][j - 1], input[i][j + 1], input[i + 1][j - 1],
                        input[i + 1][j], input[i + 1][j + 1]
                    };
                }
            }

            return neighbours;
        }
        
    }
}