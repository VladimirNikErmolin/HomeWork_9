// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int numberM = EnterInt("Введите число m:");
int numberN = EnterInt("Введите число n:");

Console.WriteLine($"Значение функции Аккермана для чисел m = {numberM} и n = {numberN} равно: {FindAckermannFunction(numberM, numberN)}");

int EnterInt(string hint)
{
    Console.WriteLine(hint);
    return int.Parse(Console.ReadLine()!);
}

int FindAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FindAckermannFunction(m - 1, 1);
    }
    else
    {
        return FindAckermannFunction(m - 1, FindAckermannFunction(m, n - 1));
    }
}
