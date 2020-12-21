using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = null; 
            Console.WriteLine("What is your favourite food?"); 
            mystring = Console.ReadLine(); 
            switch (mystring) 
            { case "Pizza": 
                Console.WriteLine("Oh yeah pizza!"); 
                break; 
                case "Chips": 
                    Console.WriteLine("I love chips to!");
                    break; 
                default: 
                    Console.WriteLine("I guess it was something healthy!"); 
                    break; 
            } Console.ReadLine(); 


        }
    }
}
