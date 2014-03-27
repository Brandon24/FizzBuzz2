using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(n => { Console.WriteLine(n + (n % 15 == 0 ? " FIZZBUZZ" : (n % 3 == 0 ? " FIZZ" : (n % 5 == 0 ? " BUZZ" : "")))); });


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine("FizzBuzz");
                }

    
                else if (i % 10 == 0)
                {
    
    
                    System.Console.WriteLine("Fizz");
                
                }

                
                else if (i % 5 == 0)
                {
               
    
                    System.Console.WriteLine("Buzz");
                }

                
                {

                    Console.WriteLine(i.ToString());
                }
       
            }

        }
    }
}