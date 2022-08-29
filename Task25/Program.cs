
using System;


class Myclass
{



    static void Main(string[] args)
    {
        Console.WriteLine("Введите 2 числа через пробел: ");

        string[] str = Console.ReadLine().Split(" ");
        int a = Convert.ToInt32(str[0]);
        int b = Convert.ToInt32(str[1]);

        Console.WriteLine($"Число {a} в степени {b} = {myPow(a, b)}");
        Console.ReadLine();
    }



    static double myPow(int a, int b)
    {
        return Math.Pow(a, b);
    }
}