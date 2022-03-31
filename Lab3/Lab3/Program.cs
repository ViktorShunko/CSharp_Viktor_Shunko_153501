using System;

namespace Lab3
{
    public class Program
    {
        static public void Main(string[] args)
        {
           
        }
        static public int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static public int Z(int x, int y)
        {
            return Min(x, 2*y + x) - Min(7*x + 2*y, y);
        }
    }
}
