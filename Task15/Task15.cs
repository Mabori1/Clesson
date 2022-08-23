//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да
// 1 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите цифру дня недели: ");
        int day = Convert.ToInt32(Console.ReadLine());

        if (day < 1 && day > 7)
        {
            System.Console.WriteLine("Некорректное число.");            
            return;
        }          
        else if(day == 6 || day == 7) 
                System.Console.WriteLine("Выходной день.");
                else
                System.Console.WriteLine("Не выходной день.");

        
    }
}