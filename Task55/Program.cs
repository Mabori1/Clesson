// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7




int[,] CreateAndFillArray(int a, int b)
{
    if(a != b){
    System.Console.WriteLine("Замена невозможна.");
    System.Environment.Exit(1);
    }

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

int[,] replacementRows(int[,] arr)
{
   

    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int temp1 = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp1;
        }
    }

    return arr;
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



int[,] array = CreateAndFillArray(6, 6);
PrintArray(array);

System.Console.WriteLine();

int[,] arr = replacementRows(array);
PrintArray(arr);
