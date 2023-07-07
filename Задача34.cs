/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве*/

int[] array = new int[10];

Console.WriteLine("Исходный массив: ");

int positives = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");

    if (array[i] % 2 == 0)
    {
        positives++;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Количество чётных элементов в данном массиве: {positives}. ");