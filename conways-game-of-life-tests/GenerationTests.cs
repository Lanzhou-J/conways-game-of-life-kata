using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class GenerationTests
    {
        [Fact]
        public void GetCellStateShould_ReturnStateOfCell_WhenCellIndexWasProvided()
        {
            var deadCell = new Cell();
            var liveCell = new Cell();
            liveCell.ChangeState();
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var generation = new Generation(cells);
            var result = generation.GetCellState(0, 0);
            Assert.Equal(State.Dead, result);
        }
        
        [Fact]
        public void GetLiveNeighboursCountsShould_ReturnAllZeros_WhenCellsAreAllDead()
        {
            var deadCell = new Cell();
            var liveCell = new Cell();
            liveCell.ChangeState();
            var cells = new[] {
                new[]{deadCell, deadCell, deadCell},
                new []{deadCell, deadCell, deadCell},
                new []{deadCell, deadCell, deadCell}
            };
            
            var expectLiveNeighboursCounts = new[] {
                new[]{0,0,0},
                new []{0,0,0},
                new []{0,0,0}
            };
            
            var generation = new Generation(cells);
            
            Assert.Equal(expectLiveNeighboursCounts, generation.LiveNeighboursCounts);
        }
    }
}