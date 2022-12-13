// ** Задача 66 **
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

start:
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (M > N)
{
    Console.WriteLine("Извините, число М должно быть меньше числа N.");
    Console.WriteLine("Повторите ввод чисел!");
    goto start;
}

Console.Write($"Сумма натуральных чисел от {M} до {N} равна {SumOfNumbers(M, N)}");
Console.WriteLine();

int SumOfNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumOfNumbers(start + 1, end));
}