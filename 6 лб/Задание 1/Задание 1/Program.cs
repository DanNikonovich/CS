using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        // Находим индекс первого двоеточия
        int colonIndex = input.IndexOf(':');

        // Если двоеточие найдено, выводим подстроку до него
        if (colonIndex != -1)
        {
            string result = input.Substring(0, colonIndex);
            Console.WriteLine("Часть строки до первого двоеточия: " + result);
        }
        else
        {
            Console.WriteLine("Двоеточие не найдено в строке.");
        }
    }
}
