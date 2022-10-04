namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));


        }
        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                return (num * Factorial(num - 1));

            }
        }
    }
}