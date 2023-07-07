// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int firstDigit = number / 10000;
int secondtDigit = number / 1000 % 10;
int fourthDigit = number % 100 / 10;
int fifthDigit = number % 10;

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число: ");
    Environment.Exit(0);
}
else if ((firstDigit == fifthDigit) && (secondtDigit == fourthDigit))
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}