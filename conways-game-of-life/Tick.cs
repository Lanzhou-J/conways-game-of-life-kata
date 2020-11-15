namespace conways_game_of_life
{
    public class Tick
    {
        public static Generation GenerateNewGeneration(Generation generation)
        {

            var newCount = generation.GenerationCount + 1;
            var newGeneration = new Generation(generation.Cells, newCount);
            return newGeneration;
        }
        
        public static Generation GenerateNewGeneration()
        {
            return null;
        }
        
        // tick - uses rule and generation to create new generation
        // 1. Create a new generation with default state
        // 2. Old generation - calculayte state of each celll -  
        // 3. New generation - tell it to change the state of the cell
        // Tick -> Generation -> Cell
        public static Generation GenerateNewGeneration(Generation generation, Rule rule)
        {
            // old generation - calculating whether (0,0) is dead or live
            // get all the neighbours for (0,0)
            // this cell is alive in this interation - Live
            // Generation - this cell (0,0) - is alive
            var newCount = generation.GenerationCount + 1;
            var copyGeneration = generation; // Generation() 0000
            //To-Do: copy generation - without changing input generation. Deep Copy/ICloneable/Serialize?
            foreach (var cellArray in copyGeneration.Cells)
            {
                foreach (var cell in cellArray)
                {
                    if (cell.State == State.Live)
                    {
                        cell.ChangeState();
                    }
                }
            }
            copyGeneration = new Generation(copyGeneration.Cells, newCount);
            return copyGeneration;
        }
    }
}