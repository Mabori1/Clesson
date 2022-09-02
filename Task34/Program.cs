//Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


class Myclass
{

    static void Main(string[] args)
    {
        int a = 10;
        int[] array = createArray(a);
                
        Console.WriteLine($"В массиве из {a} рандомных элементов:\n" +
                          $"{string.Join(", ", array)}, \n" +
                          $"четных чисел: {checkChet(array)}");

    }

    static int checkChet(int[] arr)
    {
        int count = 0;

        foreach (var item in arr)
        {
            if(item % 2 == 0)
            count++;
        }
        return count;
    }

    static int[] createArray(int a)
    {
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            arr[i] = new Random().Next(100, 1000);
        }
        return arr;
    }
}