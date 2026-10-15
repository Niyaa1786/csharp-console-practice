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
        static string[] FizzBuzz(int n)
        {
            if (n < 0)
                throw new ArgumentException("n must be non-negative");

            string[] result = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) result[i - 1] = "FizzBuzz";
                else if (i % 3 == 0) result[i - 1] = "Fizz";
                else if (i % 5 == 0) result[i - 1] = "Buzz";
                else result[i - 1] = i.ToString();
            }
            return result;
        }

        // 06. Reverse string word
        static string ReverseStringLetters(string word)
        {
            var reverseLetters = word.Reverse();
            var reverseWord = string.Join("", reverseLetters);
            return reverseWord;
        }

        // 07. Check is string Palindrome (is same word when reverse string)
        static bool isPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                throw new ArgumentException("Word must not be null or whitespace");

            var checkWord = word.Trim().ToLower();

            var reverseLetters = checkWord.Reverse();
            var reverseWord = string.Join("", reverseLetters);

            if (reverseWord == checkWord)
            {
                return true;
            }
            return false;
        }

        // 08. Count character occurrences
        static void CheckCharOccurrences(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                throw new ArgumentException("Word must not be null or whitespace");

            var checkWord = word.Trim();
            var wordChars = checkWord.CountBy(p => p);

            foreach (var character in wordChars)
            {
                Console.WriteLine($"{character.Key}: {character.Value}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
