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

        // 04. Sum from 1 to N number
        static int TotalFromOneToN(int n)
        {
            if (n < 0)
                throw new ArgumentException("Quantity must above 0");

            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            return total;
        }

        // 05. FizzBuzz

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
