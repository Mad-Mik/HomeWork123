using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    //mijin tvabanakan arjeq
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("number 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("number 2");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("middleValue = " + result);
        }
    }
}
