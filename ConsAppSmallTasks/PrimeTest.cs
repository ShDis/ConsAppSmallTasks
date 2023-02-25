using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppSmallTasks
{
    public static class PrimeTest
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
    }
}
