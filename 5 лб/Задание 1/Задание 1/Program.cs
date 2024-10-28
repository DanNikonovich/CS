using System;
class Program
{
    static void Search(int[] a) //обработка чисел в массиве 
    {
        int plus=0, minus=0;
        for (int j=0; j < a.Length; j++ )
        {
            if ( a[j] > 0 ) plus++;
            else if (a[j] < 0 ) minus++;
        }
        if (plus > minus)
            Console.WriteLine("Больше положительных");
        else
            Console.WriteLine("Больше отрицательных");
    }
    static void Main()
    {
        Random rnd = new Random(); // инициализация случайных чисел
        int[] myArray; //создаем ссылку на массив
        Console.Write(" n = ");
        int n = int.Parse(Console.ReadLine());
        myArray = new int[n]; //выделяем память под массив требуемой длины
        for (int i = 0; i < n; i++)
        { 
            myArray[i] = rnd.Next(-25, 25);
            Console.WriteLine(myArray[i]);
        }
        Search(myArray);// вызов метода
    }
}