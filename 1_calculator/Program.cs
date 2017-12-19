using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the arithmetical operation: \n" +
                "1. Multiplication \n" +
                "2. Divide \n" +
                "3. Addition \n" +
                "4. Sutraction \n" +
                "5. Exponintation \n");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first operand:");

            int firstOperand = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first operand:");

            int secondOperand = int.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("{0} * {1} = {2}", firstOperand, secondOperand, firstOperand * secondOperand);
            }
            else if (operation == 2)
            {
                Console.WriteLine("{0} / {1} = {2}", firstOperand, secondOperand, firstOperand / secondOperand);
            }
            else if (operation == 3)
            {
                Console.WriteLine("{0} + {1} = {2}", firstOperand, secondOperand, firstOperand + secondOperand);
            }
            else if (operation == 4)
            {
                Console.WriteLine("{0} _ {1} = {2}", firstOperand, secondOperand, firstOperand - secondOperand);
            }
            else if (operation == 5)
            {
                Console.WriteLine("{0} ^ {1} = {2}", firstOperand, secondOperand, Math.Pow(firstOperand, secondOperand));
            }
        }
    }
}
