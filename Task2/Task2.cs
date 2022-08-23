
//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

internal class Task2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");

        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
            Console.WriteLine("Первое число больше второго: " + x + " > " + y);
        else if (x < y)
            Console.WriteLine("Первое число меньше второго: " + x + " < " + y);
        else
            Console.WriteLine("Числа равны: " + x + " = " + y);

        Console.WriteLine();
    }
}