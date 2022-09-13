// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку 
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка




int[,] CreateAndFillArray(int a, int b)
{
    int[,] array = new int[a, b];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[] CreateListAmountRowInArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            sumRows[cols] += array[cols, rows];
        }
    }
    return sumRows;
}

void PrintArray(int[,] array)
{
    for (int cols = 0; cols < array.GetLength(0); cols++)
    {

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            System.Console.Write(array[cols, rows]);
            System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
}


void PrintAmountRowsInArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]  + "\t");
    }
    System.Console.WriteLine();
}

void FindAndPrintMinRowInArr(int[] arr)
{
    int min = arr[0];
    int index = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {             
            min = arr[i];
            index = i;
        }

    }
        Console.Write($"{index} строка. (отчет с 0)");
        
}





int[,] array = CreateAndFillArray(4, 4);
PrintArray(array);
System.Console.WriteLine();
int[] arr = CreateListAmountRowInArray(array);
PrintAmountRowsInArray(arr);
FindAndPrintMinRowInArr(arr);
