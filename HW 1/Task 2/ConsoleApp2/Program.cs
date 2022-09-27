using System;

namespace TypeSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть тип данних");     
            string inputType = Console.ReadLine();
            Console.WriteLine("Введіть дані");
            var inputData = Console.ReadLine();
            switch (inputType)
            {
                case "int":
                    Console.WriteLine("Тип данних-int");
                    break;
                case "sbyte":
                    Console.WriteLine("Тип данних-sbyte");
                    break;
                case "bool":
                    Console.WriteLine("Тип данних-bool");
                    break;
                case "short":
                    Console.WriteLine("Тип данних-short");
                    break;
                case "ushort":
                    Console.WriteLine("Тип данних-ushort");
                    break;
                case "uint":
                    Console.WriteLine("Тип данних-uint");
                    break;
                case "long":
                    Console.WriteLine("Тип данних-long");
                    break;
                case "ulong":
                    Console.WriteLine("Тип данних-ulong");
                    break;
                case "float":
                    Console.WriteLine("Тип данних-float");
                    break;
                case "double":
                    Console.WriteLine("Тип данних-double");
                    break;
                case "decimal":
                    Console.WriteLine("Тип данних-decimal");
                    break;
                case "string":
                    Console.WriteLine("Тип данних-string");
                    break;
                default:
                    Console.WriteLine("Непідходящий тип данних");
                    break;
            }
        }
    }
}