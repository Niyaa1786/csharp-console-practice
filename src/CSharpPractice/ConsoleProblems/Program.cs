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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
