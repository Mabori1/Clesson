


    


// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
//  [-4, -8, 8, 2] -> [4, 8, -8, -2]


System.Console.WriteLine("Введите цифры массива через пробел: ");


string str = Console.ReadLine();

System.Console.WriteLine("Получен массив чисел: " + str);

int[] rez = new int[str.Length];

string[] temp = str.Split(" ");

for (int i = 0; i < temp.Length; i++)
{
    rez[i] =  Convert.ToInt32(temp[i].ToString());
    rez[i] *= -1;
    System.Console.Write(rez[i] + " ");
}

//System.Console.WriteLine($"Итоговый массив чисел: {rez.ToString()}");

