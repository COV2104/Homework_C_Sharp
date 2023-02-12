// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с которого начнется заполнение матрицы: ");
int numStart = Convert.ToInt32(Console.ReadLine());

int[,] FillSpiralMatrix()
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int count = 1;
    int istart = 0, istop = 0, jstart = 0, jstop = 0;
    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = numStart;
        count++;
        numStart++;
        if (i == istart && j < array.GetLength(1) - jstop - 1)
            j++;
        else if (j == array.GetLength(1) - jstop - 1 && i < array.GetLength(0) - jstop - 1)
            i++;
        else if (i == array.GetLength(0) - jstop - 1 && j > jstart)
            j--;
        else
            i--;

        if (i == istart + 1 && j == jstart && istart != array.GetLength(1) - jstop - 1)
        {
            istart++;
            istop++;
            jstart++;
            jstop++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Спирально заполненный двумерный массив {rows} x {columns} : ");
int[,] spiral = FillSpiralMatrix();
PrintArray(spiral);
