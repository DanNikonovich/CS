using System;

class Program
{
    static int RemoveBetweenMinAndMax(ref int[] array)
    {
        if (array.Length < 2) return array.Length;

        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++) // Находим индексы минимального и максимального элементов
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            else if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        if (minIndex > maxIndex) // Убедимся, что minIndex меньше maxIndex
        {
            int temp = minIndex;
            minIndex = maxIndex;
            maxIndex = temp;
        }

        // Удаляем элементы между minIndex и maxIndex
        int shiftCount = 0; // Считаем, сколько элементов мы удалили

        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            array[i] = int.MinValue;
            shiftCount++;
        }

        for (int i = 0; i < shiftCount; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == int.MinValue)
                    for (int k = j; k < array.Length; k++)
                    {
                        if (k == array.Length - 1)
                            array[k] = 0;
                        else
                            array[k] = array[k + 1];
                    }
            }
        }

        Array.Resize(ref array, array.Length - shiftCount); // Изменяем размер массива

        return array.Length; // Возвращаем новую длину массива
    }

    static void Main()
    {
        Random rnd = new Random(); // Инициализация случайных чисел
        int[] myArray; // Создаем ссылку на массив
        Console.Write(" n = ");
        int n = int.Parse(Console.ReadLine());
        myArray = new int[n]; // Выделяем память под массив требуемой длины

        for (int i = 0; i < n; i++)
        {
            myArray[i] = rnd.Next(-25, 25);
            Console.Write($"{myArray[i]} ");
        }
        Console.WriteLine();

        int count = 0;
        Console.WriteLine("Среднее значение: {0}", myArray.Average());

        for (int i = 0; i < myArray.Length; i++)
            if (myArray[i] < myArray.Average()) count++;

        Console.WriteLine("Кол-во элементов меньше среднего значения: {0} ", count);

        RemoveBetweenMinAndMax(ref myArray); // Вызов метода

        Console.WriteLine("Массив после удаления:");
        foreach (var item in myArray)
            Console.Write($"{item} ");
    }
}
