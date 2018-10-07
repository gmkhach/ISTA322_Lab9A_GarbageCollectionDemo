using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator Calculator = new Calculator())
            {
                Console.WriteLine($"120 / 15 = {Calculator.Divide(120, 15)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
