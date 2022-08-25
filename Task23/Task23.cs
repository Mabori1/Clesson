
//Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

class MyClass
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введите число: ");
		
		int n = int.Parse(Console.ReadLine());

		Pow3(n);
	}

	private static void Pow3(int n)
	{
		for (int i = 1; i <= n; i++)
		
			Console.Write(Math.Pow(i, 3) + " ");		
	}
}