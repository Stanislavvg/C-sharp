﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num%2 == 1)
{
    Console.WriteLine($"Число {num} - нечётное.");
}

else
{
    Console.WriteLine($"Число {num} - чётное.");
}