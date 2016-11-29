using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Rock begin = new Rock();
                string yep = begin.Body();

                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo end = Console.ReadKey(); 
                keepPlaying = end.KeyChar == 'y';
                Console.WriteLine();
            }

        }
    }
}
