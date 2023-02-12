// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество листов трехмерного массива: ");  // количество двумерных массивов входящих в трехмерный
int lists = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов трехмерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

void FillRandomArray3D(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < temp.Length;)
    {
        int num = new Random().Next(10, 100);
        int j;
        for (j = 0; j < i; j++)
        {
            if (num == temp[j])                  
                break;
        }
        if (j == i)
        {
            temp[i] = num;                 
            i++;
        }
    }
    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)                   
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = temp[index];
                index++;
            }
        }
    }
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k})\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] massiv3D = new int[lists,rows,columns];
FillRandomArray3D(massiv3D);
PrintArray(massiv3D);