using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            int counter = 1; // объявление переменной 
            int startNum = 9 + 1; // число с которого надо начинать выводить последовательность + 1 т.к. в первой итерации его выводить не надо т.к. на конце 0

            for (int i = 0; i < 5; i++) // цикл для кол-ва строк
            {
                for (int j = 0; j < counter; j++) // вложенный цикл для первых строк 
                {
                    if (j == counter - 1)
                        Console.Write($"3");
                    else
                        Console.Write($"2 ");
                }

                Console.WriteLine(); // переход на новую строку

                for (int k = 0; k < counter; k++) // вложенный цикл для вторых строк
                {
                    if (k == counter - 1)
                        Console.Write($"0");
                    else
                        Console.Write($"{Math.Abs(startNum + k)} ");
                }

                Console.WriteLine();
                counter++; // увеличение переменной
                startNum--;
            }

            Console.ReadLine();
        }
    }
}