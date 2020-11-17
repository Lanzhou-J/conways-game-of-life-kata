using System;
using System.Collections.Generic;

namespace conways_game_of_life
{
    public class Cell
    {
        public Cell()
        {
            State = State.Dead;
        }
        
        public Cell(State state)
        {
            State = state;
        }

        public State State { get; set; }
    }
}