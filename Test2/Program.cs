// 2) Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.





Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(proizvedenieChisel(n));





int proizvedenieChisel(int n){

int pr = 1;

for (int i = 1; i <= n; i++)
    pr = pr * i;

return pr;
}
