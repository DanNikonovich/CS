using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write(" x1 = "); // запрашиваем значение 
            double x1 = double.Parse(Console.ReadLine()); // считываем введённые данные 
            Console.Write(" y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write(" x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write(" y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write(" x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write(" y3 = ");
            double y3 = double.Parse(Console.ReadLine());
            double s = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);// производим вычисление
            Console.WriteLine(" Площадь треугольника, заданного координатами вершин = {0} ",s); // выводим результат
        }
    }
}