using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw1
{
    class Task1
    {
        public void Work()
        {
            Console.WriteLine("Enter sentence with letters:");
            string str = "";
            char letter;
            do
            {
                letter = Convert.ToChar(Console.ReadLine());
                str += letter;
            } while (letter != '.');
            Console.WriteLine($"Sentence => {str}");
            Thread.Sleep(1000);
        }
    }
}
