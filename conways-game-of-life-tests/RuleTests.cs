using System;
using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class RuleTests
    {
        [Fact]
        public void IsOvercrowdingForLiveCellShould_ReturnTrue_WhenLiveNeighboursOverThree()
        {
            var liveNeighbours = 4;
            var rule = new Rule();
            var result = rule.IsOvercrowdingForLiveCell(liveNeighbours);
            Assert.True(result);
        }
        
        [Fact]
        public void IsUnderpopulatedForLiveCellShould_ReturnTrue_WhenLiveNeighboursOverThree()
        {
            var liveNeighbours = 1;
            var rule = new Rule();
            var result = rule.IsUnderpopulationForLiveCell(liveNeighbours);
            Assert.True(result);
        }

    }
}