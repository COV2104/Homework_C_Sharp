// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"№ {i+1}:\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

string FindMinRows(int[,] array)
{
    int minSum = int.MaxValue;
    int minRows = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minRows = i;
        }
    }
    return $"Строка с минимальной суммой элементов находится под № {minRows + 1}, сумма = {minSum}";
}

int[,] massiv = Fill2DArray();
Console.WriteLine($"Двумерный массив {rows} x {columns} : ");
Print2DArray(massiv);
Console.WriteLine(FindMinRows(massiv));