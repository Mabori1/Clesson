// 3)Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]


int[] arr = new int[8];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(2);
}

foreach (var i in arr)
{   
    System.Console.WriteLine(i);  // arr[0]
}