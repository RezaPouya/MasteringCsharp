using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTypes.Lessons;

internal static class L_03_ValueType
{
    struct Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    struct Fraction
    {
        public int numerator;
        public int denominator;
    }
    public static void Run()
    {
        Point point = new Point();
        point.x = 0;
        point.y = 0;
        point.z = 0;
        Point point2 = new Point(1,1,1);
    }
}
