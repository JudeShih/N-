using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1; int i = 0;
            int Number = int.Parse(Console.ReadLine());
            while (i+1 <= Number)
            {
                sum = ++i * sum;
            }
            Console.WriteLine("X! = "+sum);
        }
    }
}
