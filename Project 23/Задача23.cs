// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());

for (int count = 1; count <= number; count++)
{
    Console.WriteLine($"Число {count} в третьей степени равно {count * count * count}");
}