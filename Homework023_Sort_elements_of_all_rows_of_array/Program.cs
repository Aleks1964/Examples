// ** Задача 54 **
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Массив, отсортированный по убыванию элементов в строке:");
SortArray(array);

// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minM, int maxN)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minM, maxN + 1);
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

// Метод сортировки массива по убыванию 
int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int jj = j + 1; jj < array.GetLength(0); jj++)
            {
                if (array[i, j] < array[i, jj])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, jj];
                    array[i, jj] = temp;
                }
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}