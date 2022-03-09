using System;

namespace _153501_Shunko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b;
            Console.WriteLine("Result is {0}", c);
        }
    }
}
