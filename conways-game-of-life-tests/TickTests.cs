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
        public void GenerateNewGenerationShould_ReturnAGenerationSameStateAsBeforeWithCountPlusOne_WhenNoRuleArgument()
        {
            var input = new Generation();
            Assert.Equal(1,input.GenerationCount);
            var result = Tick.GenerateNewGeneration(input);
            Assert.Equal(2,result)
            
        }
    }
}