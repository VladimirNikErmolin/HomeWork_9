// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = EnterInt("Введите число M:");
int numberN = EnterInt("Введите число N:");

int rangeMin = Min(numberM, numberN);
int rangeMax = Max(numberM, numberN);

Console.WriteLine($"Сумма ряда чисел от {numberM} до {numberN} равна: {GetSumNaturalRowBetweenMN(rangeMin, rangeMax)}");

int EnterInt(string hint)
{
    Console.WriteLine(hint);
    return int.Parse(Console.ReadLine()!);
}

int Min(int a, int b)
{
    return a < b ? a : b;
}

int Max(int a, int b)
{
    return a > b ? a : b;
}

int GetSumNaturalRowBetweenMN(int rengeMin, int rengeMax)
{
    if (rangeMax == rengeMin) return rangeMax;
    return rengeMin + GetSumNaturalRowBetweenMN(rengeMin + 1, rengeMax);
}
