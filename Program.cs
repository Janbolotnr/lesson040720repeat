using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace lesson040720
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "") break;
                if (!numbers.Contains(input))
                    numbers.Add(input);
            }
            Console.WriteLine(AggregatePositive(numbers));
        }

        static int AggregatePositive(IEnumerable<string> numbers) => numbers
            .Aggregate(
            0,
            (sum, current) =>
            {
                var number = int.Parse(current);
                return number > 0 ? sum + number : sum;
            });

       /* static int SumOfPositive(IEnumerable<string> numbers)
            => numbers   //IEnumerable<string>
                .Select(int.Parse) //IEnumerable<int>
                .Where(n => n > 0) //IEnumerable<int>
                .Aggregate(0, (sum, n) => sum + n); //int (+ можно использовать метод .Sum();)*/
    }
}

/*  while (true)
        {
            Console.Write("Enter to palindrom: ");
            var input = Console.ReadLine();

            if (input.Length <= 2)
            {
                Console.WriteLine("to short wods or empty");
            }

            Console.Write(IsPalindrom(input) ? "is Palindrom" : "it's not Palindrome");
            Console.ReadKey();
        }
    }

    public static bool IsPalindrom(string input)
    {
        string words = Reverse(input);
        return input == words;
    }

    static string Reverse(string rev)
    {
        string result = "";
        foreach (var letter in rev)
            result = letter + result;
        return result;
    }




/* Console.WriteLine(BrokenPhone("Hello World") == "hello world");*/

/* static string AccumulatorFunction(string result, string word)
  => result == string.Empty
           ? word // tuura emes kaytalash kerek!!!
           : result + " " + word;*/

/* static string BrokenPhone(string sentence)
        {
            return sentence
                 .Split(" ") // ~> ["My", "name", "John", "Doe"]
                 .Where(word => word.Length > 3) // ~>["name", "John"]
                 .Select(word => word.ToLower()) // ~> ["name", "john"]
            .Aggregate(
                    string.Empty,
                    (result, word) => result == string.Empty ? word : result + " " + word
            ); // string[] ~> string  = свертка/reduce
        }*/

/*  static string BrokenPhone(string sentence)
        {
            var words = sentence
                 .Split(" ") // ~> ["My", "name", "John", "Doe"]
                 .Where(word => word.Length > 3) // ~>["name", "John"]
                 .Select(word => word.ToLower()); // ~> ["name", "john"]

            var result = string.Empty;

            foreach (var word in words)
                result += result == string.Empty ?
                    word :
                    " " + word;//word[] ~> string

                return result;
        }*/

/* static string BrokenPhone(string sentence) => string.Join(" ",
            sentence // "My name is John Doe"
            .Split(" ") // ~> ["My", "name", "John", "Doe"]
            .Where(word => word.Length > 3) // ~>["name", "John"]
            .Select(word => word.ToLower()) // ~> ["name", "john"]
            ); // "name, john"*/
