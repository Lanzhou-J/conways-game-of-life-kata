using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class TickTests
    {
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldCellsAreDead()
        {
            //arrange
            var initial = new Board(3,3);
            
            var result = new[] {
                new[]{State.Dead,State.Dead,State.Dead},
                new[]{State.Dead,State.Dead,State.Dead},
                new[]{State.Dead, State.Dead,State.Dead}
            };

            //act
            Tick.Evolve(initial);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var actualCellValue = initial.GetCell(i, j).State;
                    var expectedCellValue = result[i][j];
                    Assert.Equal(expectedCellValue,actualCellValue);
                }
            }
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldCellsAreDeadRegardlessOfWorldSize()
        {
            //arrange
            var initial = new Board(3,4);
            
            var result = new[] {
                new[]{State.Dead,State.Dead,State.Dead, State.Dead},
                new[]{State.Dead,State.Dead,State.Dead, State.Dead},
                new[]{State.Dead, State.Dead,State.Dead, State.Dead}
            };

            //act
            Tick.Evolve(initial);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var actualCellValue = initial.GetCell(i, j).State;
                    var expectedCellValue = result[i][j];
                    Assert.Equal(expectedCellValue,actualCellValue);
                }
            }

        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasOneLiveCellInMiddle()
        {
            //arrange
            State[][] initial = new[]
            {
                new[] {State.Dead, State.Dead, State.Dead},
                new[] {State.Dead, State.Live, State.Dead},
                new[] {State.Dead, State.Dead, State.Dead}
            };
            
            var input = new Board(initial);

            var result = new[] {
                new[]{State.Dead,State.Dead,State.Dead},
                new[]{State.Dead,State.Dead,State.Dead},
                new[]{State.Dead, State.Dead,State.Dead}
            };
          
            //act
            Tick.Evolve(input);
          
            //assert
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var actualCellValue = input.GetCell(i, j).State;
                    var expectedCellValue = result[i][j];
                    Assert.Equal(expectedCellValue,actualCellValue);
                }
            }
        }
    }
}