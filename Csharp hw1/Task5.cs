using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw1
{
    class Task5
    {
        public void Work()
        {
            Console.Write("Enter number: ");
            Int32 num = Int32.Parse(Console.ReadLine());
            bool work = false;
            for (int i = 1; num / i != 0 ; i*=10)
            {
                Console.Write(num % (i * 10) / i);
                work = true;
            }
            if (!work)
            {
                Console.Write('0');
            }
            Console.WriteLine();
        }
    }
}
