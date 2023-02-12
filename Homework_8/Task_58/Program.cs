// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] ProductTwoMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}

if (columns1 == rows2)
{
    int[,] matrix1 = Fill2DArray(rows1, columns1);
    Console.WriteLine($"Первая матрица {rows1} x {columns1} : ");
    Print2DArray(matrix1);
    int[,] matrix2 = Fill2DArray(rows2, columns2);
    Console.WriteLine($"Вторая матрица {rows2} x {columns2} : ");
    Print2DArray(matrix2);
    int[,] productMatrix = ProductTwoMatrix(matrix1, matrix2);
    Console.WriteLine($"Произведение первой и второй матриц {rows1} x {columns2} : ");
    Print2DArray(productMatrix);
}
else Console.WriteLine("Найти произведение данных матриц невозможно");
