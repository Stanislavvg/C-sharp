// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

if (m < n)
{
    int SummMethod(int start)
    {
        if (start == n) return start;
        if (start < n) return start + SummMethod(start + 1);
        else return 0;
    }
    Console.WriteLine(SummMethod(m));
}
else
{
    int SummMethod(int start)
    {
        if (start == m) return start;
        if (start < m) return start + SummMethod(start + 1);
        else return 0;
    }
    Console.WriteLine(SummMethod(n));
}

