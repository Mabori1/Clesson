// 5) Создайте массив А[12] с помощью генератора случайных чисел 
// с элементами от –20 до 10 и выведите его на экран. Замените все 
// отрицательные элементы массива числом 0.


int[] arr = new int[12];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-20, 11);
}
foreach (var i in arr)
{   
    System.Console.Write((i) + " ");  // arr[0]
}

System.Console.WriteLine();

foreach (var i in arr)
{   
    if (i < 0)
    System.Console.Write(0);  // arr[0]
    else        
        System.Console.Write(i);  // arr[0]
    
    
}