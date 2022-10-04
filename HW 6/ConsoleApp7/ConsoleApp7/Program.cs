namespace ConsoleApp7
{

    internal class Program
    {
        static void Main(string[] args)
        //1. Створити клас "Системи числення". Створити калькулятор, який підтримує обчислення в заданій системі числення.
        {
            Console.WriteLine("Choose calculation system: bin - 1 dex - 2 hex - 3");
            string sys = Console.ReadLine();

            Console.WriteLine("Enter first number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            Console.WriteLine("Choose operation");
            string o = Console.ReadLine();
            int res;
            string sysres = "";
            int num1 = 0;
            int num2 = 0;


            switch (sys)
            {
                case "1":
                case "bin":
                    num1 = Convert.ToInt32(a, 2);
                    num2 = Convert.ToInt32(b, 2);
                    break;

                case "3":
                case "hex":
                    num1 = Convert.ToInt32(a.ToUpper(), 16);
                    num2 = Convert.ToInt32(b.ToUpper(), 16);
                    break;
                case "2":
                case "dex":
                    num1 = int.Parse(a);
                    num2 = int.Parse(b);
                    break;

                default:
                    Console.WriteLine("Wrong system");
                    break;

            }

            switch (o)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine($"{res}");
                    Console.WriteLine($"{Convert.ToString(res, 2)}");
                    Console.WriteLine($"{res.ToString("X")}");
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine($"{res}");
                    Console.WriteLine($"{Convert.ToString(res, 2)}");
                    Console.WriteLine($"{res.ToString("X")}");
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine($"{res}");
                    Console.WriteLine($"{Convert.ToString(res, 2)}");
                    Console.WriteLine($"{res.ToString("X")}");
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine($"{res}");
                    Console.WriteLine($"{Convert.ToString(res, 2)}");
                    Console.WriteLine($"{res.ToString("X")}");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;


                    
            }
        }
    }
}