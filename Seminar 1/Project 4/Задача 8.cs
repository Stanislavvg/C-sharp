/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 2;

Console.WriteLine($"Вот все чётные числа от 2 до {num}:");

while (count <= num)
{
    Console.WriteLine($"{count}");
    count = count + 2;
}