using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw1
{
    class Task4
    {
        public void Work()
        {
            Console.WriteLine("Enter A:");
            Int32 a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            Int32 b = Int32.Parse(Console.ReadLine());
            if (a > b)
            {
                Int32 tmp = a;
                a = b;
                b = tmp;
            }
            for (; a <= b; a++)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }
    }
}
