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
        
        public static Generation GenerateNewGeneration(Generation generation, Rule rule)
        {
            var newCount = generation.GenerationCount + 1;
            var newGeneration = new Generation(generation.Cells, newCount);
            return newGeneration;
        }
    }
}