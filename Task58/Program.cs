// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int[,] FillOneMatrix(int n)
{
    int[,] M = new int[n, n];
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            M[i, j] = new Random().Next(0, 10);
        }
    }

    return M;
}



int[,] MultiMatrix(int[,] a, int[,] b)
{    
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0}\t", a[i, j]);
        }
        Console.WriteLine();
    }
}



Console.WriteLine("Введите размерность квадратных матриц: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mA = FillOneMatrix(n);
int[,] mB = FillOneMatrix(n);

Console.WriteLine("\n Матрица A:");
Print(mA);
Console.WriteLine("\n Матрица B:");
Print(mB);
Console.WriteLine("\nМатрица C = A * B:");
int[,] mC = MultiMatrix(mA, mB);
Print(mC);