
using System;

int[] vvodABC()
{
    System.Console.WriteLine("Введите 3 числа через пробел:");

    string temp = Console.ReadLine();
    string[] s = temp.Split(' ');
    int[] nums = new int[s.Length];

    for (var i = 0; i < s.Length; i++)
    {
        nums[i] = Convert.ToInt32(s[i]);
    }
    return nums;
}

bool test(int a, int b, int c)
{
    if ((a <= b + c) && (b <= a + c) && (c <= a + b))
    return true;

    return false;
}


void print(bool b)
{
    if (b)
    {System.Console.WriteLine("Можно создать треугольник!");}

    System.Console.WriteLine("Нельзя создать треугольник.");
}


print(test(vvodABC()));
