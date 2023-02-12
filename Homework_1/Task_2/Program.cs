// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

Console.Write("Введите превое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;

Console.WriteLine($"Максимальным из чисел {number1} и {number2} является число {max}");
