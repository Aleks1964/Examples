// ** Задача 56 **
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

start:
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Введите количество столбцов массива (НЕ равное количеству строк): ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (rows == columns)
{
    Console.WriteLine("Вы не выполнили условие (Количество строк НЕ должно равняться количеству столбцов)");
    Console.WriteLine();
    Console.WriteLine("Повторите ввод!");
    Console.WriteLine();
    goto start;
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Индекс строки с наименьшей суммой элементов = {ArrayMinRowSum(array)}.");
Console.WriteLine();

// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод поиска индекса строки с наименьшей суммой элементов
int ArrayMinRowSum(int[,] array)
{
    int MinSumIndexRow = 0;
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i, j];
        }
        // Console.Write($"sum[{i}] = {sum[i]}, ");
        // Console.WriteLine();
    }
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (sum[MinSumIndexRow] > sum[i + 1])
        {
            MinSumIndexRow = i + 1;
        }
    }
    return MinSumIndexRow;
}