using System;
namespace Example
{
    class Program
    {
        static void Main()
        {

            Console.Write(" x = ");// запрашиваем значение
            double x = double.Parse(Console.ReadLine()); //считывает введенное значение
            Console.Write(" y = ");
            double y = double.Parse(Console.ReadLine());
            //использование условного оператора
            if (((x * x + y * y < 1) && (y < 0)) || ((x * x + y * y < 1) && (y > 0) && (x < 0))) // определение точки в области значений
                Console.WriteLine("точка внутри графика"); // вывод 
            else
            {
                if (((x * x + y * y <= 1) && (y <= 0)) || ((x * x + y * y <= 1) && (y >= 0) && (x <= 0))) // определение точки на границе
                    Console.WriteLine("точка находится на границе "); // вывод
                else
                    Console.WriteLine("Точка вне графика");// вывод исключения
            }
            Console.ReadKey();
        }
    }
}