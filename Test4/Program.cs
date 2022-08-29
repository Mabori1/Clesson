
// 4) Создайте массив А[7] с помощью генератора случайных чисел 
// и выведите его на экран. Увеличьте все его элементы в 2 раза.

int[] arr = new int[7];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(101);
}
foreach (var i in arr)
{   
    System.Console.Write((i) + " ");  // arr[0]
}

System.Console.WriteLine();

foreach (var i in arr)
{   
    System.Console.Write((i*2) + " ");  // arr[0]
}