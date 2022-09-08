// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Задача дополнительная 
// Задайте двумерный массив. Найдите сумму элементов, находящихся ниже главной диагонали 


void createArray(int a, int b) 
{
    int[,] array = new int[a,b];
    int sum = 0;

    for (int m = 0; m < array.GetLength(0); m++)
    {
        System.Console.WriteLine();

        for (var n = 0; n < array.GetLength(1); n++)
        {
            array[m,n] = new Random().Next(0, 10);

            if(n == m) sum += array[m,n];

            System.Console.Write(array[m,n]);
            System.Console.Write(" ");
        }        

    }   

    System.Console.WriteLine(sum);
}

createArray(3,4);