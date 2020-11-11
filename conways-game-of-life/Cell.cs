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

        public State State { get; set; }
        public Coordinate Coordinate { get; set; }

        public void ChangeState()
        {
            State = State == State.Live ? State.Dead : State.Live;
        }
        
    }
}