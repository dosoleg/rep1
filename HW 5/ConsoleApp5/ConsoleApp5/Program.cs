using System;

namespace PasswordLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Login");
                string login = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (login == "Administrator" && password == "admin")
                {
                    Console.WriteLine("Welcome Administrator");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password or login try again please");
                }
            }
            

        }
    }
}