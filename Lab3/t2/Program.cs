using System;

namespace t2
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter z :");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b :");
            double b = Convert.ToDouble(Console.ReadLine());

            if(Class1.Z_is_less_than_1(z))
                Console.Write("Первая ветка\n");
            else
                Console.Write("Вторая ветка\n");

            Console.Write("Результат равен ");
            Console.Write(Class1.Y(Class1.X(z,b)));
        }
    }
}
