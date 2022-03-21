using System;

namespace Lab2
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;

            bool f = true;
            while (f)
            {
                Console.Write("Enter a three-digit number: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Bb(a);
                c = Cc(a);
                if (b_is_bigger(b,c))
                    Console.WriteLine("The first number is greater");
                else
                    Console.WriteLine("The second number is greater");

                Console.WriteLine("Enter 1 to exit, enter 2 to continue");
                d = Convert.ToInt32(Console.ReadLine());
                switch(d)
                {
                    case 1: f = false; break;
                    case 2: break;
                }
            }      
        }
        static public int Bb(int a)
        {
            return a / 100;
        }
        static public int Cc(int a)
        {
            return (a / 10) % 10;
        }
        static public bool b_is_bigger(int b, int c)
        {
            return b > c;
        }
    }
}
