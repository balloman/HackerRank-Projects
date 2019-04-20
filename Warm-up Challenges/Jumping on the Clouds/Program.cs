using System;

namespace Jumping_on_the_Clouds
{
    internal class Program
    {

        static int JumpingOnClouds(int[] c)
        {
            int steps = 0;
            int place = 0;
            while (true)
            {
                if (place == c.Length-1)
                {
                    break;
                }

                if (c.Length > place + 2 && c[place + 2] == 0)
                {
                    place = place + 2;
                    steps += 1;
                }
                else
                {
                    place = place + 1;
                    steps += 1;
                }
            }

            return steps;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(JumpingOnClouds(new[] {0, 0, 0, 1, 0, 0}));
        }
    }
}