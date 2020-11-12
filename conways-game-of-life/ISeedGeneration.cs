namespace conways_game_of_life
{
    public interface ISeedGeneration
    {
        public Generation SeedWorld(IInput input);
    }
}