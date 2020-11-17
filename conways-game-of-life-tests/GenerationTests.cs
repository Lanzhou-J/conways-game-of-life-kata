using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class GenerationTests
    {
        [Fact]
        public void GetCellStateShould_ReturnStateOfCell_WhenCellIndexWasProvided()
        {
            var cellStates = new[] {
                new[]{State.Dead, State.Live},
                new []{State.Dead, State.Live}
            };
            var generation = new Generation(cellStates,1);
            var result = generation.GetCellState(0, 0);
            Assert.Equal(State.Dead, result);
        }

        [Fact]
        public void GetNeighboursShould_ReturnEmptyList_WhenNoArgument()
        {
            var cellStates = new[] {
                new[]{State.Dead, State.Live},
                new []{State.Dead, State.Live}
            };
            var generation = new Generation(cellStates,1);
            var result = generation.GetNeighbours();
            Assert.Empty(result);
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnEmptyList_WhenThereIsOnlyOneCell()
        {
            var cellStates = new[] {
                new[]{State.Dead}
                };
            var generation = new Generation(cellStates,1);
            var firstCell = generation.Cells[0][0];
            var result = generation.GetNeighbours(firstCell);
            Assert.Empty(result);
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnAListWithOneCell_WhenThereAreTwoCells()
        {
            var dead = State.Dead;
            var live = State.Live;
            var cellStates = new[] {
                new[]{dead, live},
            };
            var generation = new Generation(cellStates,1);
            var firstCell = generation.Cells[0][0];
            var result = generation.GetNeighbours(firstCell);
            Assert.NotEmpty(result);
            Assert.Equal(live,result[0].State);
        }

    }
}