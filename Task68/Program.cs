// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int[] inputNums()
{
    System.Console.WriteLine("Введите два положительных\n" +
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



int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}

int[] nums = inputNums();

int res = Akkerman(nums[0], nums[1]);
System.Console.WriteLine($"Результат работы функции Аккермана\n" +
                          $"для чисел {nums[0]}, {nums[1]}: {res}\n");


