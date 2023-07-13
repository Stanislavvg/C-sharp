// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
var random = new Random();

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        array[x, y] = Math.Round(random.NextDouble(), 1);
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