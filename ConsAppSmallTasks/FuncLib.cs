using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsAppSmallTasks
{
    public static class FuncLib
    {
        static public bool IsPrimeNuber(int n)
        {
            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }

        // В григорианском календаре обычный год состоит из 365 дней.Поскольку фактическая продолжительность звездного года(период обращения Земли вокруг Солнца) составляет 365.2425 дней, «високосный год» в 366 дней используется один раз каждые четыре года для устранения ошибки, вызванной тремя обычными(но короткими) годами.Любой год, который делится на 4 без остатка, является високосным годом: например, 1988, 1992 и 1996 годы являются високосными годами.
        // Тем не менее, есть еще небольшая ошибка, которая должна быть учтена.Чтобы устранить эту ошибку, григорианский календарь предусматривает, что год, который делится без остатка на 100 (например, 1900) является високосным годом только в том случае, если он также без остатка делится на 400.
        // По этой причине следующие годы не являются високосными:
        // 1700, 1800, 1900, 2100, 2200, 2300, 2500, 2600
        // Это потому, что они делятся без остатка на 100, но не на 400.
        // Следующие годы – високосные: 1600, 2000, 2400
        // Это потому, что они делятся без остатка на 100 и 400.
        public static bool IsLeapYear(int year)
        {
            bool isLeapYear = false;

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                isLeapYear = true;
            }

            return isLeapYear;
        }

        public static void Arrow()
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

        public static bool IsInsideCircle(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y + 1, 2));
            if (distance > 2)
                return false;
            return true;
        }

        public static void DrawTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
        }

        public static void SortFileOfStrings()
        {
            string[] lines = File.ReadAllLines("input.txt");

            SelectionSort(lines);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void SelectionSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (MyCompareTo(arr[j], arr[minIndex]) == 0 || MyCompareTo(arr[j], arr[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    string temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static int MyCompareTo(string strA, string strB)
        {
            //ignore upper
            strA = strA.ToLower();
            strB = strB.ToLower();

            if (strA.Length > strB.Length)
                return 1;
            if (strA.Length < strB.Length)
                return 0;

            // Check symbols
            for (int i = 0; i < Math.Min(strA.Length, strB.Length); i++)
            {
                // ASCII
                if (strA[i] != strB[i])
                {
                    return (strA[i] - strB[i]) < 0 ? 0 : 1;
                }
            }

            return -1;
        }

        public static void Email()
        {
            
        }
    }
}
