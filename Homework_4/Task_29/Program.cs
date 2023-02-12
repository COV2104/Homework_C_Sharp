// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// [5] -> [1, 2, 5, 7, 19]; [3] -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива с индексом [{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]} ]");
    }
}

int[] massiv = FillArray(size);
PrintArray(massiv);
