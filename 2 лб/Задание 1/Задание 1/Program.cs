using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write(" x = "); //запрашивает сумму вклада
            double x = double.Parse(Console.ReadLine()); //считывает введенное значение
            if (x == -2) Console.WriteLine("Функция будет не определена");
            else
            {
                double y = 3.0 / Math.Abs(Math.Pow(x, 3) + 8);// подсчёт и округление 
                Console.WriteLine(" y = {0:f5}", y);//выводит сумму денег
            }
        }
    }
}