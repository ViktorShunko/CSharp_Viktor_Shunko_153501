using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Class1
    {
        static public double X(double z, double b)
        {
            return Z_is_less_than_1(z) ? z / b : Math.Sqrt(Math.Pow(z * b, 3));
        }
        static public double Y(double x)
        {
            return Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) + Math.Pow(Math.Sin(Math.Pow(x, 2)), 3) - Math.PI;
        }
        static public bool Z_is_less_than_1(double z)
        {
            return z < 1;
        }
    }
}
