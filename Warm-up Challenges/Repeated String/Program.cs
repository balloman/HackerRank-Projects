namespace Repeated_String
{
    internal class Program
    {
        static long repeatedString(string s, long n)
        {
            int length = s.Length;
            long multiplier = n / length;
            int appearance = 0;
            foreach (char variable in s)
            {
                if (variable == 'a')
                {
                    appearance++;
                }
            }

            var remainder = n % length;
            var output = multiplier * appearance;
            foreach (char variable in s.Substring(0, (int) remainder))
            {
                if (variable == 'a')
                {
                    output++;
                }
            }
            return output;
        }
        
        public static void Main(string[] args)
        {
            repeatedString("aba", 10);
        }
    }
}