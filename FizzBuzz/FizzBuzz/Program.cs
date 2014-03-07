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
            for (int i = 1; i <= 100; i++)
            {
                if (i  3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine("FizzBuzz");
                }

    
                else if (i % 10 == 0);
                {
    
    
                    System.Console.WriteLine("Fizz");
                
                }

                
                else if (i % 5 == 0);
                {
               
    
                    System.Console.WriteLine("Buzz");
                }

                else
                {

                    Console.WriteLine(i.ToString());
                }
       
            }

        }
    }
}