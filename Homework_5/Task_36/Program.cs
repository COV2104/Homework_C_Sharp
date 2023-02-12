// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] PrintArray()
{
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[n];
for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(-100, 101);
    if (i < (num.Length - 1)) Console.Write($"{num[i]}, ");
    else Console.WriteLine($"{num[i]} ");
}
return num;
}
string SumOddElements(int [] array)
{
int sum = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1)
    {
        sum = sum + array[j];
    }
}
return $"Сумма нечетных элементов = {sum}";
}
try
{
    int [] mas = PrintArray();
    System.Console.WriteLine(SumOddElements(mas));
}
catch
{
    System.Console.WriteLine("error");
}