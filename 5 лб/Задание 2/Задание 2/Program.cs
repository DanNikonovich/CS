using System;

class Program
{
    static void Main()
    {
        int[,] matrix;

        Random rnd = new Random(); // инициализация случайных чисел
        Console.Write(" n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(" m = ");
        int m = int.Parse(Console.ReadLine());
        matrix = new int[n,m]; //выделяем память под массив требуемой длины
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.Next(-100, 100);
            }
        }
        Console.WriteLine();
        OutPut(ref matrix); // вызов метода
        Zeros(ref matrix); // вызов метода
        Console.WriteLine();
        OutPut(ref matrix); // вызов метода

    }

    static void OutPut(ref int[,] A) // Выводим результат
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static void Zeros(ref int[,] A)
    {
        int n = A.GetLength(0); //кол-во строк
        int m = A.GetLength(1); // кол-во столбцов
        int max = A[0, 0]; // переменна максимума
        int maxRow = 0; //индекс строки максимального элемента

        // Поиск наибольшего элемента и его строки
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxRow = i;
                }
            }
        }

        // Обнуление строки с наибольшим элементом
        for (int j = 0; j < m; j++)
        {
            A[maxRow, j] = 0;
        }
    }
}
