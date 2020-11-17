using System;
using System.Collections.Generic;

namespace conways_game_of_life
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            State = State.Dead;
        }
        
        public Cell(State state, int x, int y)
        {
            State = state;
            X = x;
            Y = y;
        }

        public State State { get; set;}
    }
}