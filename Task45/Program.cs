﻿

int[] fillingArray (int lengthArr){    


    int[] array = new int[lengthArr];

    for (var i = 0; i < array.Length; i++)

        array[i] = new Random().Next(0,100);        
    
    return array;
}

void printArray (int[] arr)
{
    for (var i = 0; i < arr.Length-1; i++)
    {        
        Console.Write(arr[i] + " ");
    }
    
    Console.Write(arr[arr.Length-1]);
    System.Console.WriteLine();

}

int[] reverseArray(int[] arr)
{
    
    return arr;
}


int[] temp = fillingArray(15);
printArray(temp);
printArray(reverseArray(temp));