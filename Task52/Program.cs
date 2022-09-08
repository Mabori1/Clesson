// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

double[] SumNumColumnArray(int[,] array)
{
    double[] sumCols = new double[array.GetLength(0)];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        for (var rows = 0; rows < array.GetLength(1); rows++)
        {            
                sumCols[rows] += array[cols, rows];    
        }
    }
    return sumCols;
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


void PrintSumNumColumnArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]/arr.Length + "\t");
    }    
}

int[,] array = CreateAndFillArray(8, 8);
PrintArray(array);
System.Console.WriteLine();
double[] arr =  SumNumColumnArray(array);
PrintSumNumColumnArray(arr);
