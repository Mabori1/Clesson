using System.Threading;
// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2



int[,] CreateAndFillArray(int a, int b)
{
    int[,] array = new int[a, b];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        //System.Console.WriteLine();

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] replacementRows(int[,] array)
{
    int[,] temp  =  array.Clone() as int[,];

    for (int cols = 0, colsEnd = array.GetLength(0)-1; cols < array.GetLength(0); cols++ )
    {
        for (int rows = 0, rowsEnd = array.GetLength(1)-1; rows < array.GetLength(1); rows++)
        {
            if(cols == 0)
            temp[cols,rows] = array[colsEnd, rows];

            if(cols == array.GetLength(0)-1)
            temp[array.GetLength(0)-1,rows] = array[0, rows];

        }
    }
    return temp;
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



int[,] array = CreateAndFillArray(4,4);
PrintArray(array);

System.Console.WriteLine();

int[,] arr = replacementRows(array);
PrintArray(arr);
