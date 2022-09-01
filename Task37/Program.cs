// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
//  и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.WriteLine( "[{0}]", string.Join(",", sumArr(createRandomArray())));




int[] createRandomArray()
{
int[] array = new int [13];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(1, 10);  

System.Console.WriteLine( "[{0}]", string.Join(",", array));
    return array;

}

int[] sumArr(int[] array)
{    
    int[] temp = new int[array.Length/2];

    for (int i = 0, j = array.Length -1 ; i < array.Length/2; i++, j--)
    {
       temp[i] = array[i] * array[j];        
    }

    return temp;
}