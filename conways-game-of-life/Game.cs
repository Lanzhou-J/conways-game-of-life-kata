using System.Collections.Generic;

namespace conways_game_of_life
{
    public class Game
    {
        public Game( Generation initialGeneration, Rule rule, ISeedGeneration iSeed)
        {
            Generations = new List<Generation>(){InitialGeneration};
            InitialGeneration = initialGeneration;
            Rule = rule;
            _iSeed = iSeed;
        }

        public List<Generation> Generations { get; }
        public Generation InitialGeneration { get; }

        public Rule Rule { get; }

        private ISeedGeneration _iSeed;
        private IOutputGeneration _iOutput;

    }
}