using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            string statementType = "switch";

            switch (statementType)
            {
                case "DecisionMaking":
                    Console.Write(" is a decision making statement.");
                    break;
                case "if.else":
                    Console.Write("if-else");
                    break;
                case "ternary":
                    Console.Write("Ternary operator");
                    break;
                case "switch":
                    Console.Write("switch statement");
                    goto case "DecisionMaking";
            }
            Console.ReadKey();
        }
    }
}
