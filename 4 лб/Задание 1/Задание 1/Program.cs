using System;
namespace Example
{
    class Program
    {
        static void LengthT(double x1, double y1, double x2, double y2, out double res)
        {
            res = Math.Sqrt(((x2 - x1)* (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }

        static double Fmax(double a, double b)
        {
            return (a > b) ? a : b;
        }

        static void Main()
        {
            double x0 = 0 , y0 = 0, res;
            Console.WriteLine("Первая точка:");// запросили 
            Console.Write("x1 = ");// запросили 
            double x1 = double.Parse(Console.ReadLine());// считали
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());// считали
            Console.WriteLine("Вторая точка:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Третья точка:");
            Console.Write("a = ");             
            double a = double.Parse(Console.ReadLine());  
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            LengthT(x1,y1,x2,y2,out res); // вызов функции для поска длины
            Console.WriteLine("Длина отрезка между вершинами : {0}",res); // вывод результата
            Console.WriteLine("Максимальное значение : {0}", Fmax(a, b)); // вызывает и выводит результат
            double L1,L2,L3;
            LengthT(x0, y0, x1, y1, out L1); //вызывает
            LengthT(x0, y0, x2, y2, out L2); //вызывает
            LengthT(x0, y0, a, b, out L3); //вызывает
            double max = Fmax(Fmax(L1, L2), L3); // объявление переменной 
                if (max == L1) 
                Console.WriteLine("Первая точка дальше"); // вывод
            else if (max == L2)
                Console.WriteLine("Вторая точка дальше"); //вывод
            else Console.WriteLine("Третья точка дальше"); //вывод
        }
    }
}