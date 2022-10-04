using System;

namespace PasswordLogin
{
    class Program
    {
        static int Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(0, 15);
            int y = random.Next(0, 15);
            Console.WriteLine($"X = {x} Y = {y}");
            double hit = Math.Sqrt(x * x + y * y);

            if (hit > 10)
            {
                Console.WriteLine($"{Math.Round(hit, 2)} it's a miss");
                return 1;
            }
            int result = (int)(10 - hit);
            Console.WriteLine($"Result = {result}");


            return 0;
        }
    }
}
