using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class GenerationTests
    {
        [Fact]
        public void GenerateNewGenerationShould_ReturnAGenerationWithCountPlusOne_WhenNoRuleArgument()
        {
            var deadCell = new Cell();
            var liveCell = new Cell();
            liveCell.ChangeState();
            Assert.Equal(State.Live,liveCell.State);
            Cell[][] cells = new Cell[][]
            {
                new[]{deadCell,deadCell},
                new[]{deadCell,deadCell}};
            var generation = new Generation(cells);
            Assert.Equal(1, generation.GenerationCount);
            var result = generation.GenerateNewGeneration();
            Assert.Equal(2,result.GenerationCount);
        }
    }
}