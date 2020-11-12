using System;

namespace conways_game_of_life
{
    public class Rule
    {

        public bool IsOvercrowdingForLiveCell(int liveNeighbours)
        {
            return liveNeighbours > 3;
        }
        
        public bool IsUnderpopulationForLiveCell(int liveNeighbours)
        {
            return liveNeighbours < 2;
        }
        
        public bool IsGreatConditionForDeadCell(int liveNeighbours)
        {
            return liveNeighbours == 3;
        }
    }
}