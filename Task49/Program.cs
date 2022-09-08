 //Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
 
 
int[,] CreateAndFullArray(int a, int b)
{
   int[,] array = new int[a,b];
 
   for (int m = 0; m < array.GetLength(0); m++)
   {
       //System.Console.WriteLine();
 
       for (var n = 0; n < array.GetLength(1); n++)
       {
           array[m,n] = new Random().Next(2,3);
       }
   } 
   return  array;
}
 
void PowChetIndex(int[,] array)
{
   for (int m = 0; m < array.GetLength(0); m++)
   {
       //System.Console.WriteLine();
 
       for (var n = 0; n < array.GetLength(1); n++)
       {
           bool notNullIndex = (n != 0) && (m != 0);
           if(notNullIndex && (m % 2 == 0) && (n % 2 == 0)) 
           {
               array[m,n] = (int)Math.Pow(array[m,n], 2);          
           }
       }
   }
}
 
void PrintArray(int[,] array)
{
   for (int m = 0; m < array.GetLength(0); m++)
   {
 
       for (var n = 0; n < array.GetLength(1); n++)
       {
           System.Console.Write(array[m,n]);
           System.Console.Write(" ");
       }
       System.Console.WriteLine();
   }
}
 
int[,] array = CreateAndFullArray(8,8);
PrintArray(array);
System.Console.WriteLine();
PowChetIndex(array);
PrintArray(array);
