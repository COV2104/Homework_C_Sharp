// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

// 1 вариант:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = 0;
if (number >= 100)
{
    while (number >= 100)
    {
        number3 = number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра в числе = {number3}");
}
else
    Console.WriteLine("Третьей цифры в числе нет");

// 2 вариант:

string ThirdDigitNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    string result = "Третьей цифры в числе нет ";
    int number3 = 0;
    if (number >= 100)
    {
        while (number >= 100)
        {
            number3 = number % 10;
            number = number / 10;
        }
        result = $"Третья цифра в числе = {number3}";
    }
    return result;
}
try
{
    Console.WriteLine(ThirdDigitNumber());
}
catch
{
    Console.WriteLine("error: Необходимо вводить цифры");
}
