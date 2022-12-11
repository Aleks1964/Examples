// ** Задача 58 **
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

// Определение. Произведением двух матриц А и В называется матрица С,
// элемент которой, находящийся на пересечении i-й строки и j-го столбца,
// равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку)
// элементы j-го столбца матрицы В.
// Из этого определения следует формула элемента матрицы C:

// Cij = Ai1 * B1j + Ai2 * B2j + … +Ain * Bnj

start:
Console.Write("Введите количество строк первой матрицы A: ");
int rowsA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы A: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Введите количество строк второй матрицы B: ");
int rowsB = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы B: ");
int columnsB = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (columnsA != rowsB)
{
    Console.WriteLine("Извините, указанные Вами матрицы перемножить НЕВОЗМОЖНО!)");
    Console.WriteLine();
    Console.WriteLine("Повторите ввод размеров матриц!");
    Console.WriteLine();
    goto start;
}

int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
Console.WriteLine($"Матрица А[{rowsA}*{columnsA}]:");
PrintArray(arrayA);
Console.WriteLine();

int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);
Console.WriteLine($"Матрица B[{rowsB}*{columnsB}]:");
PrintArray(arrayB);
Console.WriteLine();

int[,] arrayC = new int[rowsA, columnsB];
arrayC = ProductMatrices(arrayA, arrayB);

Console.WriteLine($"Произведение двух матриц А[{rowsA}*{columnsA}] и В[{rowsB}*{columnsB}] = матрица С[{rowsA}*{columnsB}]:");
PrintArray(arrayC);
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

// Метод поиска произведение двух матриц
int[,] ProductMatrices(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                array3[i, j] += array1[i, n] * array2[n, j];
            }
        }
    }
    return array3;
}