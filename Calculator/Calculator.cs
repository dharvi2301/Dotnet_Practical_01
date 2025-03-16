using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Subtract(int a,int b)
        {
            return a - b;
        }

        public long Multiply(long a,long b)
        {
            return a * b;
        }

        public float Divide(float a,float b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by 0 is not allowed.");
                
            }
            return (float)a / b;
        }
    }
}
