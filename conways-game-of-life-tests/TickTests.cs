using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class TickTests
    {
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationOfNull_WhenNoArgument()
        {
            var result = Tick.GenerateNewGeneration();
            Assert.Null(result);
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationWithCountPlusOne_WhenNoRuleArgument()
        {
            var deadCell = new Cell();
            var cells = new[] {
                new[]{deadCell}
            };
            var input = new Generation(cells, 1);
            Assert.Equal(1,input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input);
            Assert.Equal(2, result.GenerationCount);
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationWithCountPlusOne_WhenNoRuleArgument_WithLiveCells()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var input = new Generation(cells,1);
            Assert.Equal(1,input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input);
            Assert.Equal(2, result.GenerationCount);
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationWithSameCellStates_WhenNoRuleArgument()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var input = new Generation(cells,1);
            var result = Tick.GenerateNewGeneration(input);
            for (int i = 0; i < input.Row; i++)
            {
                for (int j = 0; j < input.Column; j++)
                {
                    var expectState = input.Cells[i][j].State;
                    var actualState = result.Cells[i][j].State;
                    Assert.Equal(expectState,actualState);
                }
            }
        }

        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationOfDeadCells_AccordingToRule()
        {
            var deadCell = new Cell();
            
            var cells = new[] {
                new[]{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
            };
            var input = new Generation(cells,1);
            var rule = new Rule();
            var result = Tick.GenerateNewGeneration(input,rule);
            for (int i = 0; i < input.Row; i++)
            {
                for (int j = 0; j < input.Column; j++)
                {
                    var expectState = input.Cells[i][j].State;
                    var actualState = result.Cells[i][j].State;
                    Assert.Equal(expectState,actualState);
                }
            }
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationOfDeadCells_AccordingToRule_WhenGenerationSizeChanges()
        {
            var deadCell = new Cell();
            
            var cells = new[] {
                new[]{deadCell, deadCell,deadCell,deadCell},
                new []{deadCell, deadCell,deadCell,deadCell},
                new []{deadCell, deadCell,deadCell,deadCell},
            };
            var input = new Generation(cells,1);
            var rule = new Rule();
            var result = Tick.GenerateNewGeneration(input,rule);
            for (int i = 0; i < input.Row; i++)
            {
                for (int j = 0; j < input.Column; j++)
                {
                    var expectState = input.Cells[i][j].State;
                    var actualState = result.Cells[i][j].State;
                    Assert.Equal(expectState,actualState);
                }
            }
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationOfDeadCells_WhenALiveCellIsUnderpopulated()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            var cells = new[] {
                new[]{deadCell, deadCell,deadCell},
                new []{deadCell, liveCell,deadCell},
                new []{deadCell, deadCell,deadCell},
            };
            
            var expectCells = new[] {
                new[]{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
            };
            var input = new Generation(cells,1);
            var rule = new Rule();
            Assert.Equal(1, input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input,rule);
            Assert.Equal(1, input.GenerationCount);
            Assert.Equal(2, result.GenerationCount);
            Assert.Equal(2, Generation.LatestGenerationCount);
            for (int i = 0; i < input.Row; i++)
            {
                for (int j = 0; j < input.Column; j++)
                {
                    var expectState = expectCells[i][j].State;
                    var actualState = result.GetCellState(i,j);
                    var inputState = input.GetCellState(i, j);
                    Assert.Equal(expectState,actualState);
                    if (i==1&&j==1)
                    {
                        Assert.NotEqual(expectState,inputState);
                    }
                }
            }
        }
    }
}