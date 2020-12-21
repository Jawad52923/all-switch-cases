using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
         
         string grade = Console.ReadLine();
            switch (grade.ToLower())
            {
                case "a":
                    Console.WriteLine("Excellent!");
                    break;
                case "B":
                case "C":
                    Console.WriteLine("Well done");
                    break;
                case "D":
                    Console.WriteLine("You passed");
                    break;
                case "F":
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
            Console.ReadLine();
        }
    }
}
