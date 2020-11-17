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
            var liveCell = new Cell(State.Live);
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var generation = new Generation(cells,1);
            var result = generation.GetCellState(0, 0);
            Assert.Equal(State.Dead, result);
        }
        
        [Fact]
        public void LiveNeighboursCountsShould_EqualTo2DArrayOfAllZeros_WhenCellsAreAllDead()
        {
            var deadCell = new Cell();

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
            
            var generation = new Generation(cells,1);
            var counts = generation.GetLiveNeighboursCounts();
            
            Assert.Equal(expectLiveNeighboursCounts, counts);
        }
        
        [Fact]
        public void LiveNeighboursCountsShould_EqualToCorrectValue_WhenTheGenerationHasOneLiveCelld()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            
            var cells = new[] {
                new[]{deadCell, deadCell, deadCell},
                new []{deadCell, liveCell, deadCell},
                new []{deadCell, deadCell, deadCell}
            };
            
            var expectLiveNeighboursCounts = new[] {
                new[]{1,1,1},
                new []{1,0,1},
                new []{1,1,1}
            };
            
            var generation = new Generation(cells,1);
            var counts = generation.GetLiveNeighboursCounts();
            
            Assert.Equal(expectLiveNeighboursCounts, counts);
        }
        
        [Fact]
        public void LiveNeighboursCountsShould_EqualToCorrectValue_WhenTheGenerationHas2LiveCelld()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            
            var cells = new[] {
                new[]{deadCell, deadCell, deadCell},
                new []{deadCell, liveCell, liveCell},
                new []{deadCell, deadCell, deadCell}
            };
            
            var expectLiveNeighboursCounts = new[] {
                new[]{2,2,2},
                new []{2,1,1},
                new []{2,2,2}
            };
            
            var generation = new Generation(cells,1);
            var counts = generation.GetLiveNeighboursCounts();
            
            Assert.Equal(expectLiveNeighboursCounts, counts);
        }
    }
}