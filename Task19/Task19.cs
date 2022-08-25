
//Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
using System;

class  Task19
{
    static void Main(string[] args)
    {
       bool b =  IsPalindrom(Console.ReadLine());

       System.Console.WriteLine(b);
    }

    static bool IsPalindrom(string str)
    {
        if(str[0] == str[4] && str[1] == str[3])
            return true;

        return false;    
    }    
}