// Задача 7: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число ");

int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(x % 10);