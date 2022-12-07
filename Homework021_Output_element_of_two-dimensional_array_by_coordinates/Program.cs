// ** Задача 50 **
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Введите индекс строки элемента массива: ");
int rowsNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс столбца массива: ");
int columnsNumber = int.Parse(Console.ReadLine()!);

ArrayElement(array, rowsNumber, columnsNumber);

// ------------------Методы-----------------------
// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
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

// Метод проверки принадлежности элемента массиву
void ArrayElement(int[,] array, int m, int n)
{
    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine($"Элемент с позицией {m} и {n} не принадлежит данному массиву чисел");
    }
    else
    {
        Console.WriteLine($"Элемент на позиции массива array[{m}, {n}] равен {array[m, n]}.");

    }
}