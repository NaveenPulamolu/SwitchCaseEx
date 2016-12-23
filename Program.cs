using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            float c = 0;
            String operand;
            Console.WriteLine("Enter the First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an operand (+, -, *, /)");
            operand = Console.ReadLine();
            switch (operand)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid Entry, Please enter (+, -, *, /)");
                    break;

            }
            Console.WriteLine("The answer is {0}", c);
            Console.ReadLine();
        }
    }
}
