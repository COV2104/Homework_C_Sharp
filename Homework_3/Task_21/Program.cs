// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

// 1 вариант:

Console.Write("Введите координату x точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B ");
int zb = Convert.ToInt32(Console.ReadLine());
double distance = Math.Round(Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2)),2);
Console.WriteLine($"Расстояние между точками составляет {distance}");

// 2 вариант:

double DistancePoints()
{
    Console.WriteLine("Введите координаты точки А (через запятую): ");
    int[] coordinatesA = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
    Console.WriteLine("Введите координаты точки B (через запятую): ");
    int[] coordinatesB = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

    double sum = 0;
    for (int i = 0; i < coordinatesA.Length; i++)
    {
        sum = sum + Math.Pow((coordinatesB[i] - coordinatesA[i]), 2);
    }
    double distance = Math.Round(Math.Sqrt(sum), 2);
    return distance;
}
try
{
    double dist = DistancePoints();
    Console.WriteLine($"Расстояние между точками составляет {dist}");
}
catch
{
    System.Console.WriteLine("error: Необходимо вводить цифры");
}
