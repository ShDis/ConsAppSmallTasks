using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppSmallTasks
{
    class Program
    {
        static void Help()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--------------------" +
                "\nquit" +
                "\nhelp" +
                "\nisprime <positive_int>" +
                "\nisleapyear <int_year_YYYY_format>" +
                "\narrow" +
                "\npoint <double_x> <double_y>" +
                "\ntable" +
                "\n--------------------");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Waiting for input:");
                    string[] cmd = Console.ReadLine().ToLower().Split();
                    switch (cmd[0])
                    {
                        case "quit":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Game closed");
                            Console.BackgroundColor = ConsoleColor.Black;
                            return;

                        case "help":
                            Help();
                            break;

                        case "isprime":
                            int n = int.Parse(cmd[1]);
                            if (PrimeTest.IsPrimeNuber(n))
                                Console.WriteLine($"Number {n} is prime");
                            else
                                Console.WriteLine($"Number {n} is not prime");
                            break;

                        case "isleapyear":
                            int year = int.Parse(cmd[1]);
                            if (LeapYearTest.IsLeapYear(year))
                                Console.WriteLine($"{year} == leap year");
                            else
                                Console.WriteLine($"{year} != leap year");
                            break;

                        case "arrow":
                            ArrowArrowing.Launch();
                            break;

                        case "point":
                            double x = double.Parse(cmd[1]);
                            double y = double.Parse(cmd[2]);
                            if (PointTest.IsInsideCircle(x, y))
                                Console.WriteLine("Point found inside circle");
                            else
                                Console.WriteLine("Point is not inside circle");
                            break;

                        case "table":
                            for (int i = 1; i <= 10; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    Console.Write("{0,4}", i * j);
                                }
                                Console.WriteLine();
                            }
                            break;

                        default:
                            throw new Exception("No such command. Type 'help' for help");
                    }
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

        }
    }
}
