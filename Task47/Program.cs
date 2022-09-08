// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateAndFullArray(int a, int b)
{
   double[,] array = new double[a,b];
 
   for (int m = 0; m < array.GetLength(0); m++)
   {
       //System.Console.WriteLine();
 
       for (var n = 0; n < array.GetLength(1); n++)
       {
           array[m,n] = Math.Round(new Random().NextDouble() * 10, 1);
       }
   } 
   return  array;
}
 
void PrintArray(double[,] array)
{
   for (int m = 0; m < array.GetLength(0); m++)
   {
 
       for (var n = 0; n < array.GetLength(1); n++)
       {
           System.Console.Write(array[m,n]);
           System.Console.Write("\t");
       }
       System.Console.WriteLine();
   }
}
 
double[,] array = CreateAndFullArray(3,4);
PrintArray(array);
System.Console.WriteLine();
