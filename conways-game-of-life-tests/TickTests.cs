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
            var input = new Generation(cells);
            Assert.Equal(1,input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input);
            Assert.Equal(2, result.GenerationCount);
        }
        
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationWithCountPlusOne_WhenNoRuleArgument_WithLiveCells()
        {
            var deadCell = new Cell();
            var liveCell = new Cell();
            liveCell.ChangeState();
            var cells = new[] {
                new[]{deadCell, liveCell},
                new []{deadCell, liveCell}
            };
            var input = new Generation(cells);
            Assert.Equal(1,input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input);
            Assert.Equal(2, result.GenerationCount);
        }
    }
}