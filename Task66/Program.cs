// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int[] inputNums()
{
    System.Console.WriteLine("Введите два натуральных\n" +
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

void printAmountPositiveNums(int[] nums)
{
    int sum = 0;
    for (var i = nums[0]; i <= nums[1]; i++)
    {
        sum += i;
    }
    System.Console.WriteLine($"Сумма чисел в промежутке\n" +
                              $"от {nums[0]} до {nums[1]}: {sum}\n");

}

printAmountPositiveNums(inputNums());