using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текстовое сообщение: ");
        string input = Console.ReadLine();

        // Разделяем строку на слова, используя пробелы и знаки препинания
        char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' };
        var words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                         

        // Находим и выводим все палиндромы
        var palindromes = words.Where(IsPalindrome).Distinct();

        Console.WriteLine("Слова-палиндромы:");
        foreach (var palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }

    static bool IsPalindrome(string word)
    {
        // Приводим слово к нижнему регистру и сравниваем с его реверсированным вариантом
        string reversed = new string(word.Reverse().ToArray());
        return string.Equals(word, reversed, StringComparison.OrdinalIgnoreCase);
    }
}

//заказ, довод, кабак, казак, комок, наган, потоп, ротор, топот, шабаш, шалаш
//Заказ долго шёл, пока казак построил шалаш и устроил шабаш