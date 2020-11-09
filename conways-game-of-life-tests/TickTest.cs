using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class TickTest
    {
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
            Tick.Evolve(initial);
            Assert.Equal(results, initial);
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldCellsAreDeadRegardlessOfWorldSize()
        {
            //arrange
            var initial = new[] {
                new[]{0,0,0,0},
                new[]{0,0,0,0},
                new[]{0,0,0,0},
            };
            var results = new[] {
                new[]{0,0,0,0},
                new[]{0,0,0,0},
                new[]{0,0,0,0},
            };
          
            //act
            Tick.Evolve(initial);
            Assert.Equal(results, initial);
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
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results, initial);
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
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results, initial);
        }
        
        [Fact]
        public void EvolveShould_ReturnAWorldOfDeadCells_WhenInputWorldHasOnlyOneLiveCellRegardlessOfWorldSize()
        {
            //arrange
            var initial = new[] {
                new[]{0,0,0,0},
                new[]{0,1,0,0},
                new[]{0,0,1,0},
                new[]{0,0,0,0},
            };
            var results = new[] {
                new[]{0,0,0,0},
                new[]{0,0,0,0},
                new[]{0,0,0,0},
                new[]{0,0,0,0},
            };
          
            //act
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results, initial);
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
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results, initial);
        }
        
        [Fact]
        public void EvolveShould_LetLiveCellDie_WhenItHasMoreThan3LiveNeighboursInALargerWorld()
        {
            //arrange
            var initial = new[] {
                new[]{1,1,1,0},
                new[]{1,1,1,0},
                new[]{1,1,1,0},
                new[]{0,0,0,0},
            };
            var results = new[] {
                new[]{1,0,1,0},
                new[]{0,0,0,0},
                new[]{1,0,1,0},
                new[]{0,0,0,0}
            };
          
            //act
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results, initial);
        }
        
        [Fact]
        public void EvolveShould_EnableLiveCellLiveToTheNextGeneration_WhenHaving2or3LiveNeighbours()
        {
            //arrange
            var initial = new[] {
                new[]{1,0,1},
                new[]{0,1,0},
                new[]{1,0,0},
            };
            var results = new[] {
                new[]{1,0,1},
                new[]{0,1,0},
                new[]{1,0,0},
            };
          
            //act
            Tick.Evolve(initial);
          
            //assert
            Assert.Equal(results,initial);
        }
    }
}