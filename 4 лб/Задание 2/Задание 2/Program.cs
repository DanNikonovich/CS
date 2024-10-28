using System;

class Program
{
    static int IsStrictlyDecreasing(int number)
    {
        // Обрабатываем отрицательные числа, игнорируя знак
        number = Math.Abs(number);

        int lastDigit = number % 10; // Получаем последнюю цифру

        number /= 10; // Убираем последнюю цифру

        while (number > 0)
        {
            int currentDigit = number % 10; // Получаем текущую цифру
            // Проверяем, если текущая цифра меньше или равна последней
            if (currentDigit >= lastDigit)
            {
                return 0; // Нет, не строго убывающая
            }
            lastDigit = currentDigit; // Обновляем последнюю цифру
            number /= 10; // Убираем текущую цифру
        }

        return 1; // Да, строго убывающая
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число (0 для выхода): ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                break; // Выход из программы
            }

            int result = IsStrictlyDecreasing(num);
            Console.WriteLine(result);
        }
    }
}
