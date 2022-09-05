int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int Fib(int n)
{
    int result = 0;
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        int first = 1, second = 1;
        for (int i = 3; i <= n; i++)
        {
            result = first + second;
            first = second;
            second = result;
        }
    }
    return result;
}

void Print(int n)
{
    Console.Write("Число Фибоначчи: ");
    for(int i = 1;i<=n-1;i++)
    {
        Console.Write(Fib(i)+", ");
    }
    Console.Write(Fib(n)+", ");
}

int N = Read("Введите количество чисел Фибоначчи:");
Print(N);
