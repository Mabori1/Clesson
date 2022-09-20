// C # программа для реализации
// пузырьковой сортировки

using System;



class GFG

{
    static void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped = false;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {

                if (arr[j] > arr[j + 1])
                {
                    // поменяйте местами temp и arr [i]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }


    static void printArray(int[] arr)

    {
        for (int i = 0; i < arr.Length; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main()

    {

        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        bubbleSort(arr);

        Console.WriteLine("Sorted array");

        printArray(arr);

    }


}