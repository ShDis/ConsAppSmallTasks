using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppSmallTasks
{
    public static class PointTest
    {
        public static bool IsInsideCircle(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y + 1, 2));
            if (distance > 2)
                return false;
            return true;
        }
    }
}
