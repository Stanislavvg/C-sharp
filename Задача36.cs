/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = new int[10];

Console.WriteLine("Исходный массив: ");

int oddsSumm = array[0];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(array[i] + " ");

    if (i % 2 != 1)
    {
        oddsSumm = oddsSumm + array[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позицияхв данном массиве: {oddsSumm}. ");