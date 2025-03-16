using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInput
    {
        public int GetIntegerInput(string message)
        {
            int number;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out number))
                Console.Write("Error: Only numeric input is allowed. Please enter a valid number.");
            return number;
        }
    }
}
