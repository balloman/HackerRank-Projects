namespace Counting_Valleys
{
    internal class Program
    {
        static int CountingValleys(int n, string s)
        {
            int level = 0;
            int previousLevel = 0;
            int valleys = 0;
            foreach (char variable in s)
            {
                if (variable == 'D')
                {
                    level -= 1;
                }
                else
                {
                    level += 1;
                }

                if (level < 0 && previousLevel >= 0)
                {
                    valleys += 1;
                }

                previousLevel = level;
            }

            return valleys;
        }
        
        public static void Main(string[] args)
        {
            CountingValleys(8, "UDDDUDUU");
        }
    }
}