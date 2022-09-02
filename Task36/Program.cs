//Задача 36: Задайте одномерный массив,
//заполненный случайными числами. Найдите сумму
//элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

class Myclass
{

    static void Main(string[] args)
    {
        int a = 5;
        int[] array = createArray(a);

        Console.WriteLine($"В массиве из {a} рандомных элементов: \n" +
                          $"{string.Join(", ", array)}, \n" +
                          $"сумма элементов, стоящих на нечётных позициях: {checkChet(array)}");

    }

    static int checkChet(int[] arr)
    {
        int sumOddNum = 0;

        for (int i = 1; i < arr.Length; i += 2)                
            
                sumOddNum += arr[i];
        
        return sumOddNum;
    }

    static int[] createArray(int a)
    {
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            arr[i] = new Random().Next(0, 10);
        }
        return arr;
    }
}