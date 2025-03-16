using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");

            // Step a: Declare a string variable
            string userResponse = Console.ReadLine();

            // Step c: Add a debug point here
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is an integer");
            }
            Console.ReadLine();
        }
    }
}
