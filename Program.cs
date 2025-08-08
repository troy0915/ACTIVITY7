using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get first number input
            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();

            // Validate first number
            if (!float.TryParse(firstInput, out float firstNumber))
            {
                Console.WriteLine("Error: Please enter a valid number for the first number.");
                return;
            }
            // Get second number input
            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();

            // Validate second number
            if (!float.TryParse(secondInput, out float secondNumber))
            {
                Console.WriteLine("Error: Please enter a valid number for the second number.");
                return;
            }
            // Get operator input
            Console.Write("Enter an operator (+, -, *, /): ");
            string operatorInput = Console.ReadLine();

            // Validate operator
            if (operatorInput != "+" && operatorInput != "-" && operatorInput != "*" && operatorInput != "/")
            {
                Console.WriteLine("Error: Please enter a valid operator (+, -, *, /).");
                return;
            }
            // Perform the operation
            float result = 0;
            switch (operatorInput)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }
            // Display the result
            Console.WriteLine($"The result is: {result}");
        }
    }
}




