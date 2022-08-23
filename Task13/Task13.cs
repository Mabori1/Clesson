
//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

    System.Console.WriteLine("Введите число:");
    string str = Console.ReadLine();

    if (str.Length < 3)    
        System.Console.WriteLine("Третьей цифры нет.");        
    else
        System.Console.WriteLine($"Третья цифра числа {str} -> {str[2]}");    
    

