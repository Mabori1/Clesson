// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

class Myclass
{

    static void Main(string[] args)
    {
        int a = 10;
        double[] array = createArray(a);

        Console.WriteLine($"В массиве из {a} рандомных элементов: \n" +
                          $"{string.Join("  ", array)}, \n" +
                          $"разница между максимальным и минимальным\n" +                          
                          $"числом массива: {checkArr(array)}");




    }

    static double checkArr(double[] arr)
    {
        double max = 0, min = 0;
        foreach (var item in arr)
        {
            if (max < item) max = item;
            if (min > item) min = item;
        }
        return max - min;
    }

    static double[] createArray(int a)
    {
        double[] arr = new double[a];
        for (int i = 0; i < a; i++)
        {
            arr[i] = Math.Round((new Random().NextDouble() * 100), 2);
        }
        return arr;
    }
}