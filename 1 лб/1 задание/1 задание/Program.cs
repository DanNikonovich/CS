using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Введите сумму вклада = "); //запрашивает сумму вклада
            double a = double.Parse(Console.ReadLine()); //считывает введенное значение
            Console.Write(" Введите процент по вкладу = ");
            float b = float.Parse(Console.ReadLine()); 
            double s = Math.Round( ((a/b) + a),2) ;// подсчёт и округление 
            Console.WriteLine(" Через год сумма на вкладе = {0} р.", s);//выводит сумму денег
        }
    }
}