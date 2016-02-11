using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = CalculatorEngine.Add(10.0, 20.0);


            Console.WriteLine("Result:{0}", result);
            Console.ReadLine();
        }
    }
}
