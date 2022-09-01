// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


 int[] array = createRandomArray();

 System.Console.WriteLine(findOfRange(array));


int[] createRandomArray(){

int[] array = new int [123];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-10, 110);  

    return array;
}



int findOfRange(int[] arr)
{
    int count = 0;

    foreach (var item in arr)
    {
        if(item >= 10 && item < 100)
            count++;
    }

    return count;

}