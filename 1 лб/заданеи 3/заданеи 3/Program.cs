using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число:"); // запросили число 
        int number = int.Parse(Console.ReadLine()); // считали 
        int secondDigit = (number / 10) % 10; // нашли вторую цифру
        int lastDigit = number % 10; // нашли последнюю цифру 
        string result = (secondDigit > lastDigit) ? "Вторая цифра больше" : "Третья цифра больше"; // сравнили вторую и последнюю, и в зависимости от результата занесли соответствующий текст в result
        Console.WriteLine(result); // вывели результат 
    }
}


