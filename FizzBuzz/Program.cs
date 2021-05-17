using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            bool divisibleByThree;
            bool divisibleByFive;

            for (int i=1; i<= 100; i++ )

            {
                divisibleByThree = (i % 3 == 0);
                divisibleByFive = (i % 5 == 0);

                if (divisibleByThree && divisibleByFive)
                
                    Console.WriteLine("fizzbuzz");
                
                else if (divisibleByThree)
                
                    Console.WriteLine("fizz");
                
                else if (divisibleByFive) 
                
                    Console.WriteLine("buzz");
                
               else
                
                  Console.WriteLine(i);
                

            }
            Console.Read();
        }
    }
}
