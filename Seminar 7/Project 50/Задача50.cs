// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.WriteLine("Введите индекс по оси X: ");
int xIndex = int.Parse(Console.ReadLine());

Console.WriteLine("Введите индекс по оси Y: ");
int yIndex = int.Parse(Console.ReadLine());

double[,] array = new double[5, 5];

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        array[x, y] = new Random().Next(11);
    }
}

Console.WriteLine("Исходный массив: ");

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + "\t");
    }
    Console.WriteLine();
}

if (xIndex <= array.GetLength(0) && yIndex <= array.GetLength(1))
{
    Console.WriteLine($"Значение требуемого элемента: {array[yIndex, xIndex]}");
}
else if (xIndex > array.GetLength(0) || yIndex > array.GetLength(1)
        || xIndex<0 || yIndex<0)
{
            Console.WriteLine("Такого элемента нет в данном масиве.");
}  