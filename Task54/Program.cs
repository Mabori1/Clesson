// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




int[,] CreateAndFillArray(int a, int b)
{
    int[,] array = new int[a, b];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        //System.Console.WriteLine();

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = new Random().Next(1, 100);
        }
    }
    return array;
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



int[,] SortRowsArray(int[,] array)
{
    int[] tempArr = new int[array.GetLength(0)];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            tempArr[rows] = array[cols, rows];
        }

        SortArray(tempArr);

        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = tempArr[rows];
        }

    }
    return array;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length-1; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] < inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }    
}





int[,] array = CreateAndFillArray(4, 4);
PrintArray(array);

System.Console.WriteLine();

int[,] arr = SortRowsArray(array);

PrintArray(arr);
