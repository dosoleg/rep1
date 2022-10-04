namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity of cars");
            int quant = int.Parse(Console.ReadLine());
            

            string[][] cars = new string[quant][];

            for (int i = 0; i < quant; i++)
            {
                cars[i] = new string[4];
            }

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Enter owner's name");
                string owner = Console.ReadLine();
                Console.WriteLine("Enter car's brand");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter car's number");
                string number = Console.ReadLine();
                Console.WriteLine("Enter car's year of issue");
                string year = Console.ReadLine();
                cars[i][0] = owner;
                cars[i][1] = brand;
                cars[i][2] = number;
                cars[i][3] = year;
                NameCheck(owner);
                NumberCheck(number);

                
            }
            for (int i = 0; i < quant; i++)
            {

                Console.WriteLine($"Car's owner is {cars[i][0]}, car's brand is {cars[i][1]}, car's number is {cars[i][2]}, car's year of issue is {cars[i][3]}");
            }
        }

        static void NameCheck(string name)
        {
            string b = name[0].ToString();

            if (b != name[0].ToString().ToUpper())
            {
                Console.WriteLine("Wrong Name");

            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    string a = name[i + 1].ToString();

                    if (a != name[i + 1].ToString().ToUpper())
                    {
                        Console.WriteLine("Wrong surname");
                        break;
                    }
                }

            }


        }

        static void NumberCheck(string number)
        {
            if (number.Length != 8)
            {
                Console.WriteLine("Wrong car number");
            }
            else
            {
                if (!Char.IsLetter(number[0]) && !Char.IsLetter(number[1]) && !Char.IsLetter(number[6]) && !Char.IsLetter(number[7]))
                {
                    Console.WriteLine("Wrong car number digit's");
                }
                else
                {
                    if (!Char.IsDigit(number[2]) && !Char.IsDigit(number[3]) && !Char.IsDigit(number[4]) && !Char.IsDigit(number[5]))
                    {
                        Console.WriteLine("Wrong car number letter's");
                    }
                }
            }


        }
    }
}