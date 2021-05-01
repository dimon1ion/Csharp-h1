using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw1
{
    class Task2
    {
        public void Work()
        {
            while (true)
            {
                Console.WriteLine("Enter tram ticket number (6 digits) :");
                Int32 ticket;
                Int32 proc = 100000;
                ticket = Int32.Parse(Console.ReadLine());
                if (0 < ticket / proc && ticket / proc < 10)
                {
                    Int32 sum1 = 0;
                    Int32 sum2 = 0;
                    for (int i = 0, j = 1000000; i < 6; i++, proc /= 10, j /= 10)
                    {
                        if (i < 3)
                        {
                            sum1 += (ticket % j) / proc;
                            continue;
                        }
                        sum2 += (ticket % j) / proc;
                    }
                    if (sum1 == sum2)
                    {
                        Console.WriteLine("This ticket is lucky!");
                    }
                    else
                    {
                        Console.WriteLine("This ticket is unlucky");
                    }
                    Thread.Sleep(1000);
                    return;
                }
                Console.WriteLine("This number is not 6 digits");
            }
        }
    }
}
