using System.Reflection.Metadata.Ecma335;

namespace ConsoleProblems
{
    internal class Program
    {
        // 01. Swap two numbers
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 02. Check even or odd
        static string CheckOddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }

        // 03. Find largest number in 3 numbers
        static int LargestNumber(int a, int b, int c)
        {
            List<int> numbers = new List<int>() { a, b, c };
            return numbers.Max();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
