// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;


class Myclass
{



    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");

        string str = Console.ReadLine();        

        Console.WriteLine($"Сумма чисел в числе {str} = {mySum(str)}");
       
    }



    static int mySum(string s)
    {
        int summ = 0;

        for (int i = 0; i < s.Length; i++)
        {
           summ += Convert.ToInt32(s[i].ToString());
        }

        return summ;
    }
}