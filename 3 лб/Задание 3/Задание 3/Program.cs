using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            double y = 0; // объявленеие переменной 
            Console.Write("a = "); // запросили 
            double a = double.Parse(Console.ReadLine()); // считали 
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            for (double x = a ; x <= b; x += h) // начало цикла
            {
                if (x < 1) y = Math.Pow((Math.Pow(x, 2) - 1), 2); // условие  при х<1
                if (x > 1) y = 1 / Math.Pow(1 + x, 2); // условие  при х>1
                if (x == 0) y = 0; // условие  при х=1
                Console.WriteLine("x = {0}, y = {1}", x, y); // вывод 
            }
        }
    }
}