using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пол ('м' для мужчины, 'ж' для женщины):");// запрашивает значение
        char gender = char.Parse(Console.ReadLine());//считывание 
        Console.WriteLine(); //пустая строка 

        switch (gender) // множественный выбор
        {
                case 'м': // маленькая м
                case 'М': //большая М
                    Console.WriteLine("Возможные имена для мужчин:"); //вывод по соответствующим данным
                    Console.WriteLine("1. Александр");
                    Console.WriteLine("2. Дмитрий");
                    Console.WriteLine("3. Игорь");
                    Console.WriteLine("4. Сергей");
                    Console.WriteLine("5. Андрей");
                    break;
    
                case 'ж':
                case 'Ж':
                    Console.WriteLine("Возможные имена для женщин:");
                    Console.WriteLine("1. Анна");
                    Console.WriteLine("2. Мария");
                    Console.WriteLine("3. Екатерина");
                    Console.WriteLine("4. Ольга");
                    Console.WriteLine("5. Татьяна");
                    break;
    
                default:
                    Console.WriteLine("Ошибка: Неправильный ввод. Пожалуйста, введите 'м' или 'ж'."); // обработка не подходящих данных 
                    break;
        }

    }
}
