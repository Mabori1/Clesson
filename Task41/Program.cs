// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] inputNums()
{
    System.Console.WriteLine("Введите положительные и отрицательные\n" + 
                             "числа через пробел: ");

    string temp = Console.ReadLine();
    string[] s = temp.Split(' ');
    int[] nums = new int[s.Length];

    for (var i = 0; i < s.Length; i++)
    {
        nums[i] = Convert.ToInt32(s[i]);
    }
    return nums;
}

void printCountPositiveNums(int[] nums)
{
    int count = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        if(nums[i] > 0) count++;
    }

    System.Console.WriteLine($"Введено положительных чисел: {count}.");
}

printCountPositiveNums(inputNums());