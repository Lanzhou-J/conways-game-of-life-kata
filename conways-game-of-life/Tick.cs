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
            return generation;
        }
    }
}