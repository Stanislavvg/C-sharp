﻿Console.Write("Введите первое число: ");

int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} действительно является квадратом {num2}");
}

else
{
    Console.WriteLine($"{num1} не является квадратом {num2}");
}