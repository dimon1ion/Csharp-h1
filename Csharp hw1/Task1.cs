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
            int count = 0;
            char letter;
            do
            {
                letter = Convert.ToChar(Console.ReadLine());
                str += letter;
                if (letter == ' ') { count++; }
            } while (letter != '.');
            Console.WriteLine($"Sentence => {str}" +
                $"\nSpaces: {count}");
            Thread.Sleep(1000);
        }
    }
}
