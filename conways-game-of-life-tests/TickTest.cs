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
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldCellsAreDead()
        {
            //arrange
            var initial = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
            var results = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
          
            //act
            var output = Tick.Evolve(initial);
            Assert.Equal(initial,output);
        }

        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasOnlyOneLiveCell()
        {
            //arrange
            var initial = new[] {
                new[]{0,0,0},
                new[]{0,1,0},
                new[]{0,0,0},
            };
            var results = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
          
            //act
            var output = Tick.Evolve(initial);
          
            //assert
            Assert.NotEqual(initial,output);
            Assert.Equal(results,output);
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasOneLiveCellInMiddle()
        {
            //arrange
            var initial = new[] {
                new[]{0,0,0},
                new[]{0,1,0},
                new[]{0,0,0},
            };
            var results = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
          
            //act
            var output = Tick.Evolve(initial);
          
            //assert
            Assert.NotEqual(initial,output);
            Assert.Equal(results,output);
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasOneLiveCellInTopLeft()
        {
            //arrange
            var initial = new[] {
                new[]{1,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
            var results = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
          
            //act
            var output = Tick.Evolve(initial);
          
            //assert
            Assert.NotEqual(initial,output);
            Assert.Equal(results,output);
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasMoreThan3LiveNeighbours()
        {
            //arrange
            var initial = new[] {
                new[]{1,0,1},
                new[]{0,1,0},
                new[]{1,0,1},
            };
            var results = new[] {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,0},
            };
          
            //act
            var output = Tick.Evolve(initial);
          
            //assert
            Assert.NotEqual(initial,output);
            Assert.Equal(results,output);
        }
    }
}