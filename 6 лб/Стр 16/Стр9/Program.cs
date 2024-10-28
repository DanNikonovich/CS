using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        StringBuilder a = new StringBuilder(Console.ReadLine());

        // Удаляем из строки все знаки пунктуации
        for (int i = 0; i < a.Length;)
        {
            if (char.IsPunctuation(a[i]))
            {
                a.Remove(i, 1);
            }
            else
            {
                i++;
            }
        }

        // Преобразуем объект StringBuilder к типу string и разбиваем его на массив слов
        // Убираем лишние пробелы с помощью Split с опцией RemoveEmptyEntries
        string[] s = a.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Искомые слова: ");

        // Перебираем все слова и выводим те, которые начинаются и заканчиваются на одну и ту же букву
        foreach (string str in s)
        {
            if (str.Length > 0 && str[0] == str[str.Length - 1])
            {
                Console.WriteLine(str);
            }
        }
    }
}
// анна посетила кубок огня в египте