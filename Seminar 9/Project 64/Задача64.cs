/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

string PrintNumbers(int number)
{
    if (number == 1) return 1.ToString();
    if (number > 1) return number.ToString() + ", " + PrintNumbers(number - 1);
    else
    {
        return " ";
    }

}

Console.WriteLine(PrintNumbers(N));