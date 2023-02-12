// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int number, int exponent)
{
    int i = 1;
    int stepen = 1;
    while (i <= exponent)
    {
        stepen *= number;
        i++;
    }
    return stepen;
}

int numExponent = Exponentiation(numberA,numberB);
Console.WriteLine($"{numberA} ^ {numberB} = {numExponent}");
