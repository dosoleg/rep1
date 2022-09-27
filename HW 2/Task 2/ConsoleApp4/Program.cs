using System;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть текст");
            string text = Console.ReadLine();
            Console.WriteLine("Введіть букву для пошуку");
            char input = Console.ReadKey().KeyChar;
            int count = 0;

            foreach (char c in text)
            {
                if (c == input)
                {
                    count++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Символ {input} в тексті присутній {count} раз");
        }
    }
}
