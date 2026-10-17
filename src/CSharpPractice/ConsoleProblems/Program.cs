using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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

        // 13. Find the most element occurences in the array
        static void PrintTheMostElementOccurrences(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            var arrayWithCount = array.CountBy(p => p);

            var dictWithCount = new Dictionary<int, int>();
            foreach (var pair in arrayWithCount)
            {
                dictWithCount[pair.Key] = pair.Value;
            }

            var numberWithMostOccur = dictWithCount.MaxBy(p => p.Value);
            Console.WriteLine($"Number {numberWithMostOccur.Key}: {numberWithMostOccur.Value} times");
        }

        // 14. Two Sum
        static void PrintTwoSum(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.WriteLine($"Index {i} & {j} ({array[i]} + {array[j]})");
                        return;
                    }
                }
            }
            Console.WriteLine("No pair found");

        }

        // 15. Merged two array that has been sorted ascended
        static void PrintJoinedArrayThatSorted(int[] array1, int[] array2)
        {
            var mergedArray = array1.Concat(array2).Order();

            Console.Write("[");
            Console.Write($"{string.Join(",", mergedArray)}");
            Console.Write("]");
        }

        // 16. Print is prime number
        static void PrintIsPrime(int number)
        {
            if (isPrime(number))
            {
                Console.WriteLine("Is prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }

        // 17. Print prime numbers to N
        static void PrintPrimeNumber(int n)
        {
            if (n <= 1)
            {
                Console.Write("None");
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($"{i}, ");
                }
            }
        }
        // 18. Fibonacci sequence
        static void PrintFibSequence(int n)
        {
            int previous = 0;
            int current = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{previous},");
                int next = previous + current;
                previous = current;
                current = next;
            }
        }

        // 19. Factorial
        static void PrintFactorial(long n)
        {
            if (n < 0)
                throw new ArgumentException("n must be non-negative");

            if (n == 0)
            {
                Console.WriteLine("1");
                return;
            }

            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        // 20. Greatest Common Divisor and Least Common Multiple
        static void PrintGcdAndLcm(int a, int b)
        {
            long first = Math.Abs((long)a);
            long second = Math.Abs((long)b);
            long x = first;
            long y = second;

            while (y != 0)
            {
                long remainder = x % y;
                x = y;
                y = remainder;
            }

            long lcm = first / x * second;

            Console.WriteLine($"Greatest Common Divisor: {x}");
            Console.WriteLine($"Least Common Multiple: {lcm}");
        }

        // 22. Statistics of Student List using LINQ
        public class Student
        {
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public double Score { get; set; }

            public Student(string name, int age, double score)
            {
                Name = name;
                Age = age;
                Score = score;
            }
        };

        static void PrintStudentStatistics()
        {
            var students = new List<Student>
            {
                new("An", 20, 8.5),
                new("Bình", 21, 6.0),
                new("Chi", 20, 9.0),
                new("Dũng", 22, 5.5),
                new("Em", 21, 7.5)
            };

            var studentsAbove7 = students.Where(s => s.Score >= 7).Select(s => s.Name);
            var sortDescByScore = students.OrderByDescending(s => s.Score);
            var avgScore = students.Average(s => s.Score);
            var studentHighestScore = students.MaxBy(s => s.Score);
            var studentGroupByAgeWithCount = students.CountBy(s => s.Age);
            var studentBelow6 = students.Where(s => s.Score < 6).Select(s => s.Name);


            Console.WriteLine($"{string.Join(", ", studentsAbove7)}");

            foreach (var student in sortDescByScore)
            {
                Console.Write($"{student.Name} ({student.Score}), ");
            }
            Console.WriteLine();

            Console.WriteLine(avgScore);
            Console.WriteLine(studentHighestScore.Name);

            foreach (var student in studentGroupByAgeWithCount)
            {
                Console.WriteLine($"Age {student.Key}: {student.Value} people, ");
            }


            if (studentBelow6 != null)
            {
                Console.Write("Yes (");
                foreach (var student in studentBelow6)
                {
                    Console.Write($"{student}");
                }
                Console.Write(")");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintStudentStatistics();
        }

        public static bool isPrime(int number)
        {
            if (number <= 1)
                return false;


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
