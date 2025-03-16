using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of UserInput and Calculator classes
            UserInput userInput = new UserInput();
            Calculator calculator = new Calculator();

            // Get user input
            int num1 = userInput.GetIntegerInput("Enter first integer: ");
            int num2 = userInput.GetIntegerInput("Enter second integer: ");

            // Perform calculations
            Console.WriteLine($"The sum of {num1} and {num2} is {calculator.Add(num1, num2)}");
            Console.WriteLine($"The subtraction of {num1} and {num2} is {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"The multiplication of {num1} and {num2} is {calculator.Multiply(num1, num2)}");

            // Handle division separately to avoid division by zero
            if (num2 != 0)
            {
                Console.WriteLine($"The division of {num1} and {num2} is {calculator.Divide(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            Console.ReadKey();
        }
    }
}
