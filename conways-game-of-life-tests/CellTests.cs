using conways_game_of_life;
using Xunit;

namespace conways_game_of_life_tests
{
    public class CellTests
    {
        [Fact]
        public void ChangeStateShould_MakeCellDie_WhenItIsAlive()
        {
            var cell = new Cell();
            cell.State = State.Live;
            cell.ChangeState();
            Assert.Equal(State.Dead, cell.State);
        }
    }
}