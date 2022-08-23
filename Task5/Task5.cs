// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число ");

int x = Convert.ToInt32(Console.ReadLine());

for(int i = -x; i <= x ; i++)

    Console.Write(i + " ");
