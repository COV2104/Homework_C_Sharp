// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

// 1 вариант:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldNumber = number;
int reversNumber = 0;
while (number > 0)
{
    int lastDigit = number % 10;
    reversNumber = reversNumber * 10 + lastDigit;
    number = number / 10;
}
if (oldNumber == reversNumber)
    Console.WriteLine($"Число {oldNumber} является полиндромом");
else
    Console.WriteLine($"Число {oldNumber} не является полиндромом");

// 2 вариант (проверяет число любой размерности):

string Polindrome()
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    string result = $"Число {number} является полиндром";

    int[] array = new int[number.Length];
    for (int i = 0; i < number.Length; i++)
    {
        array[i] = Convert.ToInt32(number.Substring(i, 1));
    }

    int[] revers = new int[array.Length];
    for (int i = 0; i < revers.Length; i++)
    {
        revers[i] = array[array.Length - 1 - i];
    }

    bool find = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != revers[i])
        {
            find = true;
            break;
        }

    if (find)
        result = $"Число {number} не является полиндромом";
    return result;
}
try
{
    Console.WriteLine(Polindrome());
}
catch
{
    System.Console.WriteLine("error: Необходимо вводить числа");
}
