using System;
using System.Threading;

namespace conways_game_of_life
{
    class Program
    {
        static void Main(string[] args)
        {
            var toad = new[] {
                new[]{0,0,0,0,0,0},
                new[]{0,0,0,1,0,0},
                new[]{0,1,0,0,1,0},
                new[]{0,1,0,0,1,0},
                new[]{0,0,1,0,0,0},
                new[]{0,0,0,0,0,0}
            };
            
            var blinker = new[] {
                new[]{0,0,0,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,1,0,0},
                new[]{0,0,0,0,0},
            };
            
            var block = new[] {
                new[]{0,0,0,0},
                new[]{0,1,1,0},
                new[]{0,1,1,0},
                new[]{0,0,0,0},
            };
            
            var glider = new[] {
                new[]{0,0,0,0,0,0,0},
                new[]{0,0,0,0,1,0,0},
                new[]{0,0,1,0,1,0,0},
                new[]{0,0,0,1,1,0,0},
                new[]{0,0,0,0,0,0,0},
                new[]{0,0,0,0,0,0,0},
            };

            var initial = glider;

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
                TickInt.Evolve(initial);
            }
            
            
        }
    }
}