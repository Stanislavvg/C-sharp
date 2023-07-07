/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

int[] array = new int[10];

Console.WriteLine("Исходный массив: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(array[i] + " ");
}

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

int difference = max - min;

Console.WriteLine(" ");
Console.WriteLine($"Максимальный элемент массива: {max}. ");
Console.WriteLine($"Минимальный элемент массива: {min}. ");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference}. ");