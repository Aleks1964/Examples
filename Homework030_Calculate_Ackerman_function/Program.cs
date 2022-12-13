// ** Задача 68 **
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Пример входа                     Пример выхода
//    1   3                               5
//    2   4                               11

vvodM:
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
if (M < 0)
{
    Console.Write("Число M – отрицательное. Повторите ввод.");
    goto vvodM;
}

vvodN:
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N < 0)
{
    Console.Write("Число N – отрицательное. Повторите ввод.");
    goto vvodN;
}

Console.WriteLine($"Функции Аккермана ({M}, {N}) = {AckermannF(M, N)}");

//Метод вычисления функции Аккермана:
int AckermannF (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannF(m - 1, 1);
    if (m > 0 && n > 0) return AckermannF(m - 1, AckermannF(m, n - 1));
return AckermannF(m, n);
}