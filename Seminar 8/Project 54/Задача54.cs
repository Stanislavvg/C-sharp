// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[5, 4];

Console.WriteLine("Исходный массив:");

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        array[x, y] = new Random().Next(11);
        Console.Write(array[x, y] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Изменённый массив:");

for (int x = 0; x < array.GetLength(0) - 1; x++)
{
    for (int y = 0; y < array.GetLength(1) - 1; y++)
    {
        if (array[x, y] > array[x + 1, y])
        {
            int temp = array[x, y];
            array[x, y] = array[x + 1, y];
            array[x + 1, y] = temp;
        }
    }
}

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + "\t");
    }
    Console.WriteLine();
}