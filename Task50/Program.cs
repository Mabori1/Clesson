using System;
// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] createAndPrintArray(int a, int b)
{
    int[,] array = new int[a, b];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        System.Console.WriteLine();

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = new Random().Next(0, 10);
            System.Console.Write(array[cols, rows] + " ");
        }

    }
    return array;
}



void findInArray(int[,] arr, int findNum)
{
    bool notFind = true;

    for (int cols = 0; cols < arr.GetLength(0); cols++)
    {
        for (var rows = 0; rows < arr.GetLength(1); rows++)
        {
            if (findNum == arr[cols, rows])
            {
                System.Console.WriteLine($"\nНайдено число: {findNum} -> arr[{cols}, {rows}]");
                notFind = false;
            }

        }
    }
    if (notFind)
        System.Console.WriteLine("\nТакого числа в массиве нет.");
}

findInArray(createAndPrintArray(4, 4), 5);