using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to menu Program");
            
            Console.WriteLine("1.\tProject Management");
            Console.WriteLine("2.\t Java Programming");
            Console.WriteLine("3.\t Soft Engineering");
            Console.WriteLine ("4.\t Requirement Engineering");

            Console.WriteLine("Please enter your choice:");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice) {
            case 1: Console.WriteLine("Java Programming"); 
	   break;
            case 2: Console.WriteLine("Soft Engineering");
                    break;
            case 3: Console.WriteLine("Req Engineering"); 
                    break;
            case 4: Console.WriteLine("Proj Management"); 
                     break;
            default: Console.WriteLine("Invalid choice");
                     break;
        }//end of switch
        }
    }
}
