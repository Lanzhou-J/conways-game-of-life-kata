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
        public void GetNeighboursShould_ReturnNull_WhenNoArgument()
        {
            var deadCell = new Cell();
            var liveCell = new Cell(State.Live);
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var generation = new Generation(cells,1);
            var result = generation.GetNeighbours();
            Assert.Null(result);
        }

    }
}