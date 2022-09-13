// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateThirdMatrix()
{
    int[,,] m = new int[2, 2, 2];

    for (int x = 0; x < m.GetLength(0); x++)
        for (int y = 0; y < m.GetLength(1); y++)
            for (int z = 0; z < m.GetLength(2); z++)
                m[x, y, z] = new Random().Next(10, 100);

    return m;
}

void PrintMatrix(int[,,] M)
{

    for (int x = 0; x < M.GetLength(0); x++)
    {
        for (int y = 0; y < M.GetLength(1); y++)
        {
            for (int z = 0; z < M.GetLength(2); z++)
            {
                System.Console.Write($"{M[x, y, z]}({x},{y},{z}) ");
            }
            System.Console.WriteLine();
        }        
    }
    

}

int[,,] M = CreateThirdMatrix();

PrintMatrix(M);
