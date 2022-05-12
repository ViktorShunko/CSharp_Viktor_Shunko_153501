using System;
using lab7;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of set A");
            Set A = new Set(int.Parse(Console.ReadLine()));
            A.setSet();
            Console.WriteLine("Enter size of set B");
            Set B = new Set(int.Parse(Console.ReadLine()));
            B.setSet();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("A - B");
            (A - B).prinSet();
            Console.WriteLine("A + B");
            (A + B).prinSet();
            Console.WriteLine("A * B");
            (A * B).prinSet();
            Console.WriteLine($"A > B {A > B}");
            Console.WriteLine($"A < B {A < B}");
            Console.WriteLine($"A == B {A == B}");
            Console.WriteLine($"A != B {A != B}");

            string tmp = A;
            Console.WriteLine(tmp);

            string tmp1 = "123456";
            Set C = (Set)tmp1;
            C.prinSet();

            string tmp2 = "";
            Set D = (Set)tmp2;
            if (D)
            {
                Console.WriteLine("Isn't empty");
            }
            else
            {
                Console.WriteLine("Is empty");
            }

            string tmp_ = "AASSDD";
            Set E = (Set)tmp_;
            if (E)
            {
                Console.WriteLine("Isn't empty");
            }
        }
    }
}

