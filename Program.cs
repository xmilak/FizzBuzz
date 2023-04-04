using System;
using System.Security.Cryptography.X509Certificates;

namespace Fizzbuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            {
                Console.WriteLine($"{i}: {FizzBuzzTernary(i)}");
            }
        }
        public static string FizzBuzz(int num)
        {

            if (num % 3 == 0)
                return "fizz";
            else if (num % 5 == 0)
                return "buzz";
            else if ((num % 3 == 0) && (num % 5 == 0))
                return "fizzbuz";
            else
                return "";

        }

        public static string BuzzFizz(int num)
        {
            var answer = "";

            if (num % 3 == 0)
            {
                answer += "Buzz";
            }
            if (num % 5 == 0)
            {
                answer += "Fizz";
            }
            return answer;
        }
        public static string FizzBuzzTernary(int num)
        {
            var answer = string.Empty;

            answer = (num % 3 == 0) ? answer += "Fizz" : answer += "";
            answer = (num % 5 == 0) ? answer += "Buzz" : answer += "";

            return answer;
        }
    }
}