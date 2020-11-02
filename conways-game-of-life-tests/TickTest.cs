using System;
using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class TickTest
    {
        [Fact]
        public void EvolveShould_ReturnNull_WhenNoInput()
        {
            var output = Tick.Evolve();
            
            Assert.Null(output);
        }
    }
}