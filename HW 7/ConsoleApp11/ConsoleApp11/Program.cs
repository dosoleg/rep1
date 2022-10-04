namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee's quantity");
            int quant = int.Parse(Console.ReadLine());

            string[][] emp = new string[quant][];

            for (int i = 0; i < quant; i++ ) 
            {
                emp[i] = new string[2];
            }

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Enter employee's surname");
                string sur = Console.ReadLine();

                Console.WriteLine("Enter employee's salary");
                string sal = Console.ReadLine();
                emp[i][0] = sur;
                emp[i][1] = sal;
            }
  
            for (int i = 0; i < quant; i++)
            {
                int salary = int.Parse(emp[i][1]);

                if (salary <2000 || salary >20000 )
                {
                    Console.WriteLine($"Incorrect salary for {emp[i][0]}");
                }
            }
            for (int i = 0; i < quant; i++)
            {

                Console.WriteLine($"{emp[i][0]} has {emp[i][1]}");
            }


        }
    }
}