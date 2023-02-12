//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numEven = 1;
Console.Write($"Четные числа от 1 до {number}: ");

while (numEven <= number)
{
    if (numEven % 2 == 0) Console.Write($"{numEven}, ");
    numEven++;
}

Console.WriteLine();
