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
                "\nsort" +
                "\nemail" +
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

                        //Task 1
                        case "isprime":
                            int n = int.Parse(cmd[1]);
                            if (FuncLib.IsPrimeNuber(n))
                                Console.WriteLine($"Number {n} is prime");
                            else
                                Console.WriteLine($"Number {n} is not prime");
                            break;

                        //Task 2
                        case "isleapyear":
                            int year = int.Parse(cmd[1]);
                            if (FuncLib.IsLeapYear(year))
                                Console.WriteLine($"{year} == leap year");
                            else
                                Console.WriteLine($"{year} != leap year");
                            break;

                        //Task 3
                        case "arrow":
                            FuncLib.Arrow();
                            break;

                        //Task 4
                        case "point":
                            double x = double.Parse(cmd[1]);
                            double y = double.Parse(cmd[2]);
                            if (FuncLib.IsInsideCircle(x, y))
                                Console.WriteLine("Point found inside circle");
                            else
                                Console.WriteLine("Point is not inside circle");
                            break;

                        //Task 5
                        case "table":
                            FuncLib.DrawTable();
                            break;

                        //Task 6
                        case "sort":
                            FuncLib.SortFileOfStrings();
                            break;

                        //Task 7
                        case "email":
                            FuncLib.Email();
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
