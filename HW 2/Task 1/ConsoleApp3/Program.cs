using System;

namespace Prog
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Задайте число А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте число B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте число C");
            int c = int.Parse(Console.ReadLine());
               
            double desc = b * b - 4 * a * c;

            if (desc >= 0)
            {
                if (desc == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Відповідь x = {x}");
                    return 2;
                }
                double x1 = (-b - desc) / (2 * a);
                double x2 = (-b + desc) / (2 * a);
                Console.WriteLine($"Відповідь 1 = {x1}");
                Console.WriteLine($"Відповідь 2 = {x2}");
            }
            else
            {
                Console.WriteLine("Розв'язку немає");
                return 1;
            }
            return 0;
        } 
    }
}