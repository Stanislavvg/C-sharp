﻿Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (max<=num2)
{
    max=num2;
}

if (max<=num3)
{
    max=num3;
}

Console.Write($"Число {max} - наибольшее из введённых.");