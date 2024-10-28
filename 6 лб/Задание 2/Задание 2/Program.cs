using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Запрашиваем ввод оригинальной строки
        Console.WriteLine("Введите оригинальную строку:");
        string originalString = Console.ReadLine();

        // Запрашиваем ввод подстроки для удаления
        Console.WriteLine("Введите подстроку для удаления:");
        string substr = Console.ReadLine();

        // Создаем StringBuilder из оригинальной строки
        StringBuilder sb = new StringBuilder(originalString);

        // Удаляем все вхождения подстроки
        sb.Replace(substr, string.Empty);

        // Получаем результат
        string resultString = sb.ToString();

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(originalString);
        Console.WriteLine("nСтрока после удаления подстроки:");
        Console.WriteLine(resultString);
    }
}
//ABCDEFG132456789 HIJKLMNOP98765 АБВГДЕЁ54321 ABCDEFG132456789 ЖЗИКЛМН56789
//ABCDEFG132456789
