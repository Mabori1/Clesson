

using System;

int vvodNum(){
    
Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

 return num;
}


void translate(int num)
{
    string s = "";
    int i=0;

    int temp = num;

    while(num >= 1)
    {
        temp = num % 2;
        s +=  temp;
        num /= 2;
       
    }

    System.Console.WriteLine(s);

}

translate( vvodNum());