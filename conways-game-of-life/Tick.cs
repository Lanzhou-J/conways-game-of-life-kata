namespace conways_game_of_life
{
    public static class Tick
    {
        public static void Evolve(int[][] input)
        {
            var rowLength = input.Length;
            var columnLength = input[0].Length;

            for (var i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    input[i][j] = 0;
                }
            }
            
        }
        
        public static int[][] Evolve()
        {
            return null;
        }
    }
}