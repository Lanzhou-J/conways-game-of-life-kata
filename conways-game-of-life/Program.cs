using System;
using System.Threading;

namespace conways_game_of_life
{
    class Program
    {
        static void Main(string[] args)
        {
            var initial = new[] {
                new[]{0,0,0,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,0,0,0}
            };

            while (true)
            {
                var word = "";
                foreach (var array in initial)
                {
                    foreach (var item in array)
                    {
                        word += $"{item} ";
                    }
                    Console.WriteLine(word);
                    word = "";
                }
                Thread.Sleep(1000);
                Console.Clear();
                Tick.Evolve(initial);
            }
            
            
        }
    }
}