//Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

 class Task4
{
    private static void Main(string[] args)
    {
            Console.WriteLine("Введите первое число: ");

        int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

        int y = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Введите третье число: ");

        int z = Convert.ToInt32(Console.ReadLine());

        int max = 0;

        if (x > max) max = x;
        if (y > max) max = y;
        if (z > max) max = z;

        Console.WriteLine("Введены числа: " + x + " " + y + " " + z);
        Console.WriteLine("Максимальное число: " + max);

        Console.WriteLine();
    }
}