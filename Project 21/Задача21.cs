// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X для начала отрезка: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y для начала отрезка: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z для начала отрезка: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X для конца отрезка: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y для конца отрезка: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z для конца отрезка: ");
int z2 = int.Parse(Console.ReadLine());

double length = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow ((y2-y1),2) + Math.Pow ((z2-z1),2));
   
Console.WriteLine($"Длина отрезка: {length}");