using System;

namespace conways_game_of_life
{
    public class Cell
    {
        public Cell()
        {
            State = State.Dead;
        }

        public State State { get; set; }
        
        public void ChangeState()
        {
            State = State == State.Live ? State.Dead : State.Live;
        }

        public override string ToString()
        {
            return State switch
            {
                State.Dead => "0",
                State.Live => "1",
                _ => "0"
            };
        }
    }
}