using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class GenerationTests
    {
        private State _dead = State.Dead;
        private State _live = State.Live;
        [Fact]
        public void GetCellStateShould_ReturnStateOfCell_WhenCellIndexWasProvided()
        {
            var cellStates = new[] {
                new[]{_dead, _live},
                new []{_dead, _live}
            };
            var generation = new Generation(cellStates,1);
            var result = generation.GetCellState(0, 0);
            Assert.Equal(State.Dead, result);
        }

        [Fact]
        public void GetNeighboursShould_ReturnEmptyList_WhenNoArgument()
        {
            var cellStates = new[] {
                new[]{_dead, _live},
                new []{_dead, _live}
            };
            var generation = new Generation(cellStates,1);
            var result = generation.GetNeighbours();
            Assert.Empty(result);
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnEmptyList_WhenThereIsOnlyOneCell()
        {
            var cellStates = new[] {
                new[]{_dead}
                };
            var generation = new Generation(cellStates,1);
            var firstCell = generation.GetCell(0,0);
            var result = generation.GetNeighbours(firstCell);
            Assert.Empty(result);
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnAListWithOneCell_WhenThereAreTwoCells()
        {
            var cellStates = new[] {
                new[]{_dead, _live},
            };
            var generation = new Generation(cellStates,1);
            var firstCell = generation.GetCell(0,0);
            var result = generation.GetNeighbours(firstCell);
            Assert.NotEmpty(result);
            Assert.Equal(_live,result[0].State);

            var secondCell = generation.GetCell(0,1);
            var secondResult = generation.GetNeighbours(secondCell);
            Assert.NotEmpty(result);
            Assert.Equal(_dead,secondResult[0].State);
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnAListWith3Cells_WhenThereAreFourCells()
        {
            var cellStates = new[] {
                new[]{_dead, _live},
                new[]{_dead, _dead}
            };
            var generation = new Generation(cellStates,1);
            var cell = generation.GetCell(0,1);
            var result = generation.GetNeighbours(cell);
            Assert.Equal(3,result.Count);
            foreach (var item in result)
            {
                Assert.Equal(_dead, item.State);
            }
        }
        
        [Fact]
        public void GetNeighboursShould_ReturnAListWith8ells_WhenTheGenerationIs3times3()
        {
            var cellStates = new[] {
                new[]{_dead, _dead, _dead},
                new[]{_dead, _live, _dead},
                new[]{_dead, _dead, _dead}
            };
            var generation = new Generation(cellStates,1);
            var cell = generation.GetCell(1,1);
            var result = generation.GetNeighbours(cell);
            Assert.Equal(8,result.Count);
            foreach (var item in result)
            {
                Assert.Equal(_dead, item.State);
            }
        }

    }
}