using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int y = 5 * x + 20;
        int doubledY = y * 2;
        Console.WriteLine("Значение выражения y = 5x + 20 равно: " + y);
    }
}