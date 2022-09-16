// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


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

void printPositiveNums(int[] nums)
{

    System.Console.WriteLine($"натуральные числа в промежутке от {nums[0]} до {nums[1]}:\n");
    for (var i = nums[0]; i < nums[1]; i++)
    {

        System.Console.Write(i + ", ");
    }

}

printPositiveNums(inputNums());