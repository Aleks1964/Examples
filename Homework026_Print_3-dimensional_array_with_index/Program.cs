// ** Задача 60 **
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine($"Введите размер массива X * Y * Z");
Console.Write("Введите X = ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y = ");
int numberY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z = ");
int numberZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[numberX, numberY, numberZ];
CreateRandomArr(array3D, numberX, numberY, numberZ);
Console.WriteLine($"Трёхмерный массив размером {numberX}*{numberY}*{numberZ}:");
PrintArray(array3D);


// ------ МЕТОДЫ ------

// Метод создания 3D массива из неповторяющихся двузначных чисел. 
void CreateRandomArr(int[,,] array, int x, int y, int z)
{
    int arrLeng = x * y * z;
    int[] arr = new int[arrLeng];
    Random random = new Random();
    for (int i = 0; i < arrLeng; i++)
    {
        var num = random.Next(10, 100);
        if (arr.Contains(num))
        {
            i--;
        }
        else
        {
            arr[i] = num;
        }
    }
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = arr[count];
                count++;
            }
        }
    }
}

// Метод вывода 3D массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}