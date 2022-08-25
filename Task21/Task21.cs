//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
class Point
{
    public int x, y, z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}


class Task21
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 6 координат через пробел: ");

        string[] str = Console.ReadLine().Split(" ");

        double len = LengthOfSegment(new Point(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2])),
                                     new Point(int.Parse(str[3]), int.Parse(str[4]), int.Parse(str[5])));

        System.Console.WriteLine(len);
    }

    private static double LengthOfSegment(Point a, Point b)
    {
        //        d = √ (x b − x a ) 2 + (y b − y a ) 2 + (z b − z a ) 2

        return Math.Sqrt((b.x - a.x) * (b.x - a.x) + 
                         (b.y - a.y) * (b.y - a.y) + 
                         (b.z - a.z) * (b.z - a.z));
                
    }
}