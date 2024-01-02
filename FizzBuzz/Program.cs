using System;

namespace Program
{
    class Program
    {
        public static void FizzBuzz(int userInt)
        {
            if ((userInt % 3 == 0) && (userInt % 5 == 0)){
                Console.WriteLine("FizzBuzz");
            } else if (userInt % 3 == 0)
            {
                Console.WriteLine("Fizz");
            } else if (userInt % 5 == 0)
            {
                Console.WriteLine("Buzz");
            } else
            {
                Console.WriteLine("Number is not divisible by 3 or 5");
            }
            
        }

        static void Main(string[] args)
        {
            FizzBuzz(3);
            FizzBuzz(5);
            FizzBuzz(15);
            FizzBuzz(9);
            FizzBuzz(10);
            FizzBuzz(30);
            FizzBuzz(1);
        }
    }
}

/*
 * Given an integer:
 * If the integer is divisible by 3: print the word "Fizz"
 * If the integer is divisible by 5: print the word "Buzz"
 * If the integer is divisible by 5 and 3: print the word "FizzBuzz"
 */


