namespace conways_game_of_life
{
    public class Tick
    {
        public static Generation GenerateNewGeneration(Generation generation)
        {
            
            generation.ChangeGenerationCount();
            return generation;
        }
        
        public static Generation GenerateNewGeneration()
        {
            return null;
        }
        
        public static Generation GenerateNewGeneration(Generation generation, Rule rule)
        {
            generation.ChangeGenerationCount();
            var deadCell = new Cell();
            var cells  = new[] {
                new[]{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
                new []{deadCell, deadCell,deadCell},
            };
            generation.Cells = cells;
            return generation;
        }
    }
}