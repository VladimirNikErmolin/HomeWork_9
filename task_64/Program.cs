// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Натуральный ряд от N : {GreatNaturalRow(numberN)}");

string GreatNaturalRow(int n)
{
    if (n == 1) return "1";
    return n + "," + GreatNaturalRow(n - 1);
}
