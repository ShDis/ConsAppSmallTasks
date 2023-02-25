using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppSmallTasks
{
    public static class ArrowArrowing
    {
        public static void Launch()
        {
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Arrows to rotate, escape to exit:");
            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Clear();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("^");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("v");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(">");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("<");
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
