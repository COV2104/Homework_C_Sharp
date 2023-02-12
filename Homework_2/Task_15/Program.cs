// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 1 вариант:

Console.WriteLine("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5)
    Console.WriteLine("Рабочий");
else if (day >= 6 && day <= 7)
    Console.WriteLine("Ура, выходной!");
else
    Console.WriteLine("В неделе 7 дней");

// 2 вариант:

void WeekendCheck()
{
    Console.WriteLine("Введите число дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day >= 1 && day <= 5)
        Console.WriteLine("Рабочий");
    else if (day >= 6 && day <= 7)
        Console.WriteLine("Ура, выходной!");
    else
        Console.WriteLine("В неделе 7 дней");
}
try
{
    WeekendCheck();
}
catch
{
    Console.WriteLine("error: Необходимо вводить цифры");
}
