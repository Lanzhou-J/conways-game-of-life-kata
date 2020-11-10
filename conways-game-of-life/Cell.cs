using System;

namespace conways_game_of_life
{
    public class Cell
    {
        public Cell()
        {
            CellState = CellState.Dead;
        }

        private CellState CellState { get; set; }

        public override string ToString()
        {
            return CellState switch
            {
                CellState.Dead => "0",
                CellState.Live => "1",
                _ => "0"
            };
        }
    }
}