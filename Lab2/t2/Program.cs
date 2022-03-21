using System;

namespace t2
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int x;
            int y;
            int d;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool f = true;
            while (f)
            {
                Console.Write("Enter x-coordinate: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter y-coordinate: ");
                y = Convert.ToInt32(Console.ReadLine());

                if (One(x,y))
                    Console.Write("На границе\n");
                else if (Two(x, y))
                    Console.Write("На границе\n");
                else if (Three(x, y)) 
                    Console.Write("Нет\n");
                else
                    Console.Write("Да\n");

                Console.WriteLine("Enter 1 to exit, enter 2 to continue");
                d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1: f = false; break;
                    case 2: break;
                }
            }
        }
        static public bool One(int x, int y)
        {
            return (y == 0 || y == -15) && x >= -15 && x <= 0;
        }
        static public bool Two(int x, int y)
        {
            return (x == 0 || x == -15) && y >= -15 && y <= 0;
        }
        static public bool Three(int x, int y)
        {
            return (x < 0 && y < 0) && (x > -15 && y > -15);
        }
    }
}
