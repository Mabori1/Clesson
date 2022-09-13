// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] CreateMatrix(int size)
{
    int[,] m = new int[size, size];
    int x = 0, y = 0;
    int count = 1;

    while (size > 0)
    {

        for (int i = y; i < y + size; i++)
            m[x, i] = count++;

        for (int i = x + 1; i < x + size; i++)
            m[i, y + size - 1] = count++;

        for (int i = y + size - 2; i >= y; i--)
            m[x + size - 1, i] = count++;

        for (int i = x + size - 2; i >= x + 1; i--)
            m[i, y] = count++;

        x++;
        y++;
        size -= 2;
    }

    return m;
}

void PrintMatrix(int[,] M)
{
    for (int x = 0; x < M.GetLength(0); x++)
    {
        for (int y = 0; y < M.GetLength(1); y++)
        {
            System.Console.Write($"{M[x, y]}\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] M = CreateMatrix(n);

PrintMatrix(M);
