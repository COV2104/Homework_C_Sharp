// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] PrintArray()
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] num = new double[n];
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-101, 101);
        if (i < (num.Length - 1)) Console.Write($"{num[i]}, ");
        else Console.WriteLine($"{num[i]} ");
    }
    return num;
}
string DiffMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (max < array[j])
        {
            max = array[j];
        }
        else if (min > array[j])
        {
            min = array[j];
        }
    }
    double result = max - min;
    return $"Max = {max}, Min = {min}, разница составит = {result}";
}
try 
{
    double [] mas = PrintArray();
    System.Console.WriteLine(DiffMinMax(mas));
}
catch
{
    System.Console.WriteLine("error");
}