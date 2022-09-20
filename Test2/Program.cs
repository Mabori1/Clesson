// 2) Напишите программу, которая находит третий элемент
// массива по максимому



using System;


class GFG
{

    static void thirdLargest(int[] arr)
    {


        if (arr.Length < 3)
        {
            Console.Write(" Invalid Input ");
            return;
        }

        // Инициализируем первый, второй и третий самый большой элемент

        int first = arr[0],
            second = int.MinValue,
            third = int.MinValue;

        // Обходим элементы массива, чтобы найти третий по величине

        for (int i = 1; i < arr.Length; i++)
        {

            /* Если текущий элемент больше первого,

            затем обновите первый, второй и третий */


            if (arr[i] > first)
            {

                third = second;
                second = first;
                first = arr[i];
            }

            /* Если arr[i] находится между первым и вторым */

            else if (arr[i] > second && arr[i] != first)
            {

                third = second;
                second = arr[i];
            }

            /* Если arr[i] находится между вторым и третьим */

            else if (arr[i] > third && arr[i] != second)
            {
                third = arr[i];
            }
        }
        Console.Write($"Первый элемент: {first}\n" +
                      $"Второй элемент: {second}\n" +
                      $"Третий элемент: {third}");
    }

    public static void Main()
    {

        // int[] arr = { 12, 13, 1, 10, 34, 16 };
        int[] arr = { 12, 13, 13, 1, 10, 34, 34, 16, 16, };

        thirdLargest(arr);
    }
}
