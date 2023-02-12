// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitsNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int sumDig = SumDigitsNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sumDig}");
