using System;
// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
 

void createArray(int a, int b) 
{
    int[,] array = new int[a,b];

    for (int m = 0; m < array.GetLength(0); m++)
    {
        System.Console.WriteLine();

        for (var n = 0; n < array.GetLength(1); n++)
        {
            array[m,n] = m + n;
            System.Console.Write(array[m,n]);
        }
        
    }   
}

createArray(3,4);