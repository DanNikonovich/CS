using System;

class Program
{
    static void Main()
    {
        for (int i = 100; i < 1000; i += 1) // начало цикла
        {
            int a = i / 100; // первая цифра
            int b = i % 10;  // последняя цифра
            if (a == b) Console.WriteLine(i); // вывод 
        }
    }
}