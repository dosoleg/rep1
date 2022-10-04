namespace ConsoleApp8
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Enter system");
            string sys = Console.ReadLine();
            Console.WriteLine("Enter value");
            double temp = double.Parse(Console.ReadLine());

            double tempC = 0;
            double tempF = 0;
            double tempK = 0;

            switch (sys.ToUpper())
            {
                case "C":
                    if (temp < -273.15) 
                    {
                        Console.WriteLine("Too low Value");
                        return 1;
                    }
                    else
                    {
                        tempC = temp;
                        tempF = temp * 1.8 + 32;
                        tempK = temp + 273.15;
                    }
                    break;

                case "K":
                    if (temp < 0)
                    {
                        Console.WriteLine("Too low Value");
                        return 1;
                    }
                    else
                    {
                        tempC = temp + 273.15;
                        tempF = tempC * 1.8 + 32;
                        tempK = temp;
                    }
                    break;

                case "F":
                    if (temp < -459.67)
                    {
                        Console.WriteLine("Too low Value");
                        return 1;
                    }
                    else
                    {
                        tempC = (temp - 32) / 1.8;
                        tempF = temp;
                        tempK = tempC + 273.15;
                    }
                    break;
            }




            Console.WriteLine($"Celsius: {tempC}");
            Console.WriteLine($"Fahrenheit: {tempF}");
            Console.WriteLine($"Kelvin: {tempK}");
            return 0;
        }
    }
}