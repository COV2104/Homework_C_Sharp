// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5

// 1 вариант:

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number / 10;
int number2 = number % 10;
Console.WriteLine($"Вторая цифра в числе = {number2}");

// 2 вариант:

string SecondDigitNum()
{
    Console.WriteLine("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    string result = "Второй цифры в числе нет ";
    int number2 = 0;
    if (number >= 10)
    {
        while (number >= 10)
        {
            number2 = number % 10;
            number = number / 10;
        }
        result = $"Вторая цифра в числе = {number2}";
    }
    return result;
}
try
{
    Console.WriteLine(SecondDigitNum());
}
catch
{
    Console.WriteLine("error: Необходимо вводить цифры");
}
