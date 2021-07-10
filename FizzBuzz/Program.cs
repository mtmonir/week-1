using System;

namespace FizzBuzz // scope, prevents name collusion
{
    //class (reference type), struct (value type), interface (reference type), enum (value type)
    internal class StartingPoint
    {
        private int startPoit  = 0;
        private int endPoint = 0;

        public static void userInput()
        { 
            System.Console.WriteLine("Please enter two abc numbers:");
            

        }
        public static void Main(string[] args)
        {
            //if divisible by 3 print Fizz
            //if divisible by 5 print Buzz
            //if divisible by both print FizzBuzz
            
            // get user input
            var value = 0;
            const string fizz = "Fizz";
            const string buzz = "Buzz";

            var firstCheck = 3;
            var secondCheck = 5;

            for (;value < 50; value += 1)
            {
                if (value % firstCheck == 0)
                {
                    Console.Write(fizz);
                }

                if (value % secondCheck == 0)
                {
                    System.Console.WriteLine(buzz);
                }
            }
            
        }

    }
}
