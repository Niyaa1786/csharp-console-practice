using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

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
            var wordChars = checkWord.CountBy(c => c);

            foreach (var character in wordChars)
            {
                Console.WriteLine($"{character.Key}: {character.Value}");
            }
        }

        // 09. Anagram Checking
        static void CheckIsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                Console.WriteLine($"No");
                return;
            }

            var sortedWord1 = word1.OrderBy(c => c);
            var sortedWord2 = word2.OrderBy(c => c);

            if (sortedWord1.SequenceEqual(sortedWord2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        // 10. First character not duplicating
        static void CheckFirstCharacterNotDuplicate(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("None");
                return;
            }

            var characterWithOccurences = word.CountBy(c => c).ToDictionary(p => p.Key, p => p.Value);

            foreach (var character in characterWithOccurences)
            {
                if (character.Value == 1)
                {
                    Console.WriteLine($"{character.Key}");
                    return;
                }
                continue;
            }

            Console.WriteLine("None");
        }

        // 11. Find the largest/smallest in the array
        static void PrintMinMaxInArray(int[] array)
        {
            var largestNumb = array.Max();
            var smallestNumb = array.Min();

            Console.WriteLine($"Largest number: {largestNumb}");
            Console.WriteLine($"Smallest number: {smallestNumb}");
        }

        // 12. Remove duplicate elements in the array 
        static void PrintDistincArray(int[] array)
        {
            var distincArray = array.Distinct();

            Console.Write("[");
            Console.Write($"{string.Join(", ", distincArray)}");
            Console.Write("]");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
