using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class CountFromString
    {
        public static int MaxUnequalConsecutiveChars (string input)
        {
            int count = 0;
            int Maxcount = 0;
            for(int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > Maxcount)
                    {
                        Maxcount = count;
                    }
                    count = 0;

                }
            }
            return Maxcount;
        }
        public static int MaxLatinLettersConsecutiveIdentical(string input)
        {
            int count = 0;
            int Maxcount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsLetter(input[i]) && input[i] == input[i + 1])
                {
                    count++;
                    if (count == 1)
                    {
                        count++;
                    }
                }
                else
                {
                    if (count > Maxcount)
                    {
                        Maxcount = count;
                    }
                    count = 0;

                }
            }
            return Maxcount;
        }
        public static int MaxDigitsConsecutiveIdentical(string input)
        {
            int count = 0;
            int Maxcount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsDigit(input[i]) && input[i] == input[i + 1])
                {
                    count++;
                    if (count == 1)
                    {
                        count++;
                    }
                }
                else
                {
                    if (count > Maxcount)
                    {
                        Maxcount = count;
                    }
                    count = 0;

                }
            }
            return Maxcount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
