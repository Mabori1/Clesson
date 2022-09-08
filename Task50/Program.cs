using System;
// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] createArray(int a, int b) 
{
    int[,] array = new int[a,b];

    for (int m = 0; m < array.GetLength(0); m++)
    {
        System.Console.WriteLine();

        for (var n = 0; n < array.GetLength(1); n++)
        {
            array[m,n] = new Random().Next(0,10);
            System.Console.Write(array[m,n] + " ");
        }
        
    }   
    return array;
}

createArray(3,4);

void findInArray( int[,] arr, int findNum)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (var n = 0; n < arr.GetLength(1); n++)
        {
            if(findNum == arr[m,n])
            System.Console.WriteLine($"Найдено число: {arr[m,n]} ");
            else
            System.Console.WriteLine("Такого числа нет.");
        }
    }
}

findInArray( createArray(4,4), 12);