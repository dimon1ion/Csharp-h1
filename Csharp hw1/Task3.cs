using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw1
{
    class Task3
    {
        public void Work()
        {
            char letter;
            char change;
            do
            {
                Console.Write("Enter letter (To finish, enter '.'(dot)): ");
                letter = Convert.ToChar(Console.ReadLine());
                change = char.ToUpper(letter);
                if (change == letter)
                {
                    change = char.ToLower(letter);
                }
                Console.WriteLine($"Output << {change}");
            } while (letter != '.');

        }
    }
}
