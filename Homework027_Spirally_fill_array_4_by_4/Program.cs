// ** Задача 62 **
// Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Write("Введите количество строк массива: ");
int rowsM = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columnsN = int.Parse(Console.ReadLine()!);

//int[,] arrayMN = new int[rowsM, columnsN];

//GetArray(rowsM, columnsN);

int[,] arrayMN = GetArray(rowsM, columnsN);

//Вывод массива на экран:
Console.WriteLine();
//Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");

PrintArray(arrayMN);
//Console.WriteLine();

// ------------------Методы-----------------------

// Метод заполнения двумерного массива по спирали (против часовой стрелки)
// void GetArray(int m, int n)
int[,] GetArray(int m, int n)
{
    int[,] arrayMN = new int[m, n];
    int count = 0;
    int iCount = 0;
    int jCount = 0;
    while (count <= (m * n))
    {
        for (int i = iCount; i < (m - iCount); i++)
        {
            count++;
            arrayMN[i, jCount] = count;
            //Console.WriteLine($"1. Элемент [{i}, {jCount}] = {arrayMN[i, jCount]}, iCount = {iCount}, jCount = {jCount}");
        }
        iCount = iCount + 1;
        for (int j = (1 + jCount); j < (n - jCount); j++)
        {
            count++;
            arrayMN[m - iCount, j] = count;
            // Console.WriteLine($"2. Элемент [{m - iCount}, {j}] = {arrayMN[m - iCount, j]}, iCount = {iCount}, jCount = {jCount}");
        }
        jCount = jCount + 1;
        for (int i = (m - 1 - iCount); i > (iCount - 1); i = (i - 1))
        {
            count++;
            arrayMN[i, n - jCount] = count;
            // Console.WriteLine($"3. Элемент [{i}, {n - jCount}] = {arrayMN[i, n - jCount]}, iCount = {iCount}, jCount = {jCount}");
        }
        for (int j = n - jCount; j > jCount - 1; j = j - 1)
        {
            count++;
            arrayMN[iCount - 1, j] = count;
            // Console.WriteLine($"4. Элемент [{iCount - 1}, {j}] = {arrayMN[iCount - 1, j]}, iCount = {iCount}, jCount = {jCount}");
        }
        if ((m - 1 - iCount) < 0) break;
    }
    return arrayMN;
}

// Метод печати двумерного массива

// для спирали против часовой стрелки в строках FOR (№78 и #80)
// требуется поменять местами i и j и array.GetLength - 0 и 1

void PrintArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]}  ");
            else
            {
                Console.Write($"{array[i, j]}  ");
            }
            Thread.Sleep(100);
        }
        Console.WriteLine();
        Thread.Sleep(200);
    }
}